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
    }
}