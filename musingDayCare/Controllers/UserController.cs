
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using musingDayCareCore.UserOprations.Command.CreateNewUser;
using musingDayCareCore.UserOprations.Query.RetriveUsers.GetAllUsers;

namespace musingDayCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        /// <summary>
        /// Creates new user
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("createuser")]
        public async Task<IActionResult> CreateUser([FromBody] CreateNewUserCommand data)
        {
            var res = await Mediator.Send(data);
            return Ok(res);
        }

        [HttpGet]
        [Route("getusers")]
        public async Task<IActionResult> GetUsers()
        {
            var res = await Mediator.Send(new GetAllUserQuery());
            return Ok(res);
        }


    }
}