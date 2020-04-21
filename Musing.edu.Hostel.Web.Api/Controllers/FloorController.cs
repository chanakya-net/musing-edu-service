using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Musing.Edu.Hostel.Core.FloorCore.Commands.AddFloor;
using Musing.Edu.Hostel.Core.FloorCore.Commands.UpdateFloor;
using Musing.Edu.Hostel.Core.FloorCore.Queries.SelectFloorOnly;

namespace Musing.edu.Hostel.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloorController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAllFloors()
        {
            var res = await Mediator.Send(new SelectFloorsQuery());
            return Ok(res);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetFloorById([FromQuery] int id)
        {
            var data = new SelectFloorByIdQuery() { FloorId = id };
            var res = await Mediator.Send(data);
            return Ok(res);
        }

        [HttpGet("Building")]
        public async Task<IActionResult> GetFloorsByBuildingId([FromQuery] int id)
        {
            var data = new SelectFloorsQuery() { SelectedBuildingId = id };
            var res = await Mediator.Send(data);
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewFloor([FromBody] AddFloorCommand data)
        {
            var res = await Mediator.Send(data);
            return res == null ? (IActionResult)BadRequest("Unable to update the date") : Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFloor([FromBody] UpdateFloorCommand data)
        {
            var res = await Mediator.Send(data);
            return res == null ? (IActionResult)BadRequest("Unable to update the date") : Ok(res);
        }
    }
}