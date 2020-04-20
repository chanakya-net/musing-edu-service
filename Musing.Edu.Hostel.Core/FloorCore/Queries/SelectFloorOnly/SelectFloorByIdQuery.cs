using MediatR;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.FloorCore.Queries.SelectFloorOnly
{
    public class SelectFloorByIdQuery : IRequest<Floor>
    {
        public int FloorId { get; set; }
    }
}
