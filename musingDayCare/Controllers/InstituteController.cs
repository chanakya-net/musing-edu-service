using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using musingDayCareCore.InstituteOprations.Command;

namespace musingDayCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstituteController : BaseController
    {

        [HttpPost]
        [Route("AddInstitute")]
        public async Task<IActionResult> AddInstitute([FromBody] CreateInstituteCommand data)
        {
            var result = await Mediator.Send(data);
            return Ok(result);
        }
    }
}