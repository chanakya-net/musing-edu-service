using MediatR;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.HostelCore.Commands.HostelAdd
{
    public class AddHostelSetupCommand: HostelSetup, IRequest<HostelSetup>
    {
    }
}
