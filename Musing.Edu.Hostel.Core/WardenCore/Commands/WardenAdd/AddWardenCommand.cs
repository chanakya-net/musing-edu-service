using MediatR;

namespace Musing.Edu.Hostel.Core.WardenCore.Commands.WardenAdd
{
    public class AddWardenCommand : WardenDetailViewData, IRequest<WardenDetailViewData>
    {
    }
}
