using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Musing.Edu.Hostel.Core.HostelCore.Commands.HostelAdd;

namespace Musing.edu.Hostel.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostelController : BaseController
    {
        [HttpPost("Setup")]
        public async Task<IActionResult> AddNewHostel([FromBody] AddHostelSetupCommand data)
        {
            var res = await Mediator.Send(data);
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> AddHostelOnly([FromBody] AddHostelCommand data)
        {
            var result = await Mediator.Send(data);
            // TODO: Need to update the uri of the created
            return Created("ToBeFixed", result);
        }
    }
}