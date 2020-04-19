using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Musing.Edu.Hostel.Core.WardenCore.Queries.SelectAllWarden;
using Musing.Edu.Hostel.Core.WardenCore.Commands.WardenAdd;
using Musing.Edu.Hostel.Core.WardenCore.Commands.WardenUpdate;

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
        [HttpGet("WardenStatus")]
        public async Task<IActionResult> GetActiveWarden([FromQuery] bool isWardenActive=true)
        {
            var query = new SelectAllWardenQuery()
            {
                isActive=isWardenActive
            };
            var res = await Mediator.Send(query);
            return Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWarden([FromBody] UpdateWardenCommand command)
        {
            var res = await Mediator.Send(command);
            return res == null ? (IActionResult) BadRequest("No warden found to update.") : Ok(res);
        }
    }
}