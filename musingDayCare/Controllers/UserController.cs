using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            return Ok(res);
        }

        // POST: api/User
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegisterUserCommand value)
        {
            var response = await Mediator.Send(value);
            return Ok(response);
        }
    }
}
