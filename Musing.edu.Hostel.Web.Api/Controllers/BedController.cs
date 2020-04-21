using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Musing.Edu.Hostel.Core.BedCore.Commands.UpdateBed;
using Musing.Edu.Hostel.Core.BedCore.Queries.SelectBedOnly;
using Musing.Edu.Hostel.Core.RoomCore.Commands.AddRoom;

namespace Musing.edu.Hostel.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BedController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> AddNewBed([FromBody] AddRoomOnlyCommand data)
        {
            var res = await Mediator.Send(data);
            return res == null ? (IActionResult) BadRequest("Unable to add the room.") : Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBed([FromBody] UpdateBedCommand data)
        {
            var res = await Mediator.Send(data);
            return res == null ? (IActionResult) BadRequest("Unable to add the room.") : Ok(res);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBeds()
        {
            return Ok(await Mediator.Send(new SelectBedsOnlyQuery()));
        }

        [HttpGet("ByRoomId")]
        public async Task<IActionResult> GetAllBedsByRoom([FromQuery] int id)
        {
            var data = new SelectBedsOnlyQuery(){RoomId = id};
            var res = await Mediator.Send(data);
            return Ok(res);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetBedById([FromQuery] int id)
        {
            return Ok(await Mediator.Send(new SelectBedByIdQuery() {BedId = id}));
        }
    }
}
