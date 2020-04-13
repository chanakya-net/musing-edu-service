using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using musingDayCareCore.InstituteOprations.Command;
using musingDayCareCore.InstituteOprations.Query;

namespace musingDayCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstituteController : BaseController
    {

        [HttpPost]
        public async Task<IActionResult> AddInstitute([FromBody] CreateInstituteCommand data)
        {
            var result = await Mediator.Send(data);
            return Ok(result);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetInstitite()
        {
            var result = await Mediator.Send(new SelectInstituteQuery());
            if (result != null)
                return Ok(result);
            return BadRequest("Unable to load institute");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateInstitite([FromBody] UpdateInstituteCommand data)
        {
            var res = await Mediator.Send(data);
            if (res == null)
                return BadRequest("Unable to update the Institute.");
            return Ok(res);
        }
    }
}