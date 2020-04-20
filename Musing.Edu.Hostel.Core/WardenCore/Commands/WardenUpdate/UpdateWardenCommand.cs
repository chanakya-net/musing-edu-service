using MediatR;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.WardenCore.Commands.WardenUpdate
{
    public class UpdateWardenCommand: UpdateWardenVm, IRequest<Warden>
    {
    }
}
