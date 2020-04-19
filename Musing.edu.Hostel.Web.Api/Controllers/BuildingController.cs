using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Musing.Edu.Hostel.Core.BuildingCore.Commands.AddBuilding;
using Musing.Edu.Hostel.Core.BuildingCore.Commands.UpdateBuilding;
using Musing.Edu.Hostel.Core.BuildingCore.Queries.SelectBuildingOnly;

namespace Musing.edu.Hostel.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> AddNewBuilding([FromBody] AddBuildCommand data)
        {
            var res = await Mediator.Send(data);
            return Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBuilding([FromBody] UpdateBuildingCommand data)
        {
            var res = await Mediator.Send(data);
            return res == null ? (IActionResult) BadRequest("Unable to update the building") : Ok(res);
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllBuilding()
        {
            var res = await Mediator.Send(new SelectAllBuildingCommand());
            return Ok(res);
        }

        [HttpGet("id")]
        public async Task<IActionResult> SelectBuildingById([FromQuery] int id)
        {
            var data = new SelectBuildingByIdCommand()
            {
                BuildingId = id
            };
            var res = await Mediator.Send(data);
            return Ok(res);
        }

        [HttpGet("Hostel")]
        public async Task<IActionResult> SelectBuildingsByHostelId([FromQuery] int id)
        {
            var data = new SelectAllBuildingCommand()
            {
                HostelId = id
            };
            var res = await Mediator.Send(data);
            return Ok(res);
        }
    }
}