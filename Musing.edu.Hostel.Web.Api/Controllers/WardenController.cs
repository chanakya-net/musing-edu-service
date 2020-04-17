using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Musing.Edu.Hostel.Core.WardenCore.Commands;

namespace Musing.edu.Hostel.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardenController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> AddNewWarden([FromBody] AddWardenCommand command)
        {
            var res = await Mediator.Send(command);
            return Ok(res);
        }
    }
}