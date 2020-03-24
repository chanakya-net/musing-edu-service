﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using musingDayCareCore.UserOprations.Command;
using musingDayCareCore.UserOprations.Query.ValidateUser;

namespace musingDayCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {




        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] CheckVaildUserQuery value)
        {
            var res = await Mediator.Send(value);
            if (res != null)
            {
                var tokenData = await GetToken(res);
                return Ok(tokenData);
            }

            return NotFound("User not registred");
        }

        // POST: api/User
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegisterUserCommand value)
        {
            var response = await Mediator.Send(value);
            return Ok(response);
        }

        private async Task<dynamic> GetToken(UserInformationVM data)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, data.FirstName),
                new Claim(ClaimTypes.NameIdentifier, data.UserName),
                new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(DateTime.Now.AddDays(1)).ToUnixTimeSeconds().ToString())
            };
            foreach(var role in data.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            var token = new JwtSecurityToken(
                new JwtHeader(
                    new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("thisIsOnlyForTestingAndWillBeReplaced")), SecurityAlgorithms.HmacSha256)
                    ), new JwtPayload(claims)
                );
            var tokenOutput = new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                firstname = data.FirstName,
                lastname = data.LastName,
                username = data.UserName
            };
            return tokenOutput;
        }
    }
}
