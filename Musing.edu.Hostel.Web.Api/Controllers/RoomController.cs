using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Musing.Edu.Hostel.Core.RoomCore.Commands.AddRoom;
using Musing.Edu.Hostel.Core.RoomCore.Commands.UpdateRoom;
using Musing.Edu.Hostel.Core.RoomCore.Queries.SelectRoomOnly;

namespace Musing.edu.Hostel.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> AddNewRoom([FromBody] AddRoomOnlyCommand data)
        {
            var res = await Mediator.Send(data);
            return Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRoom([FromBody] UpdateRoomCommand data)
        {
            var res = await Mediator.Send(data);
            return res == null ? (IActionResult)BadRequest("Unable to update the data") : Ok(res);
        }

        [HttpGet("allRooms")]
        public async Task<IActionResult> SelectAllRooms()
        {
            return Ok(await Mediator.Send(new SelectAllRoomsQuery()));
        }

        [HttpGet]
        public async Task<IActionResult> SelectRoomByFloorId([FromQuery] int id)
        {
            var data = new SelectAllRoomsQuery() { FloorIdSearch = id };
            return Ok(await Mediator.Send(data));
        }

    }
}