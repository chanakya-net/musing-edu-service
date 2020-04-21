using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using musingDayCareCore.InstituteOprations.Command.InstituteCommand;
using musingDayCareCore.InstituteOprations.Command.ServiceCommand;
using musingDayCareCore.InstituteOprations.Command.VendorCommand;
using musingDayCareCore.InstituteOprations.Query.InstituteQuery;
using musingDayCareCore.InstituteOprations.Query.ServicesQuery;
using musingDayCareCore.InstituteOprations.Query.VendorQuery;

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

        [HttpPost("service")]
        public async Task<IActionResult> AddService([FromBody] AddServiceCommand data)
        {
            var res = await Mediator.Send(data);
            return Ok(res);
        }

        [HttpGet("service")]
        public async Task<IActionResult> GetAllservice()
        {
            var res = await Mediator.Send(new SelectAllServiceQuery());
            if (res == null)
                return BadRequest("No record found.");
            return Ok(res);
        }

        [HttpPost("vendor")]
        public async Task<IActionResult> AddNewVendor([FromBody]AddVendorCommand data)
        {
            var res = await Mediator.Send(data);
            return Ok(res);
        }
        [HttpGet("vendor/serviceId/")]
        public async Task<IActionResult> GetVendorByServiceId([FromQuery] int id)
        {
            var res = await Mediator.Send(new SelectVendorsByServiceQuery() { ServiceID = id });
            return Ok(res);
        }
    }
}