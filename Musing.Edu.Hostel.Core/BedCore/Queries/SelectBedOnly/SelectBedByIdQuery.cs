using MediatR;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.BedCore.Queries.SelectBedOnly
{
    public class SelectBedByIdQuery : IRequest<Bed>
    {
        public int BedId { get; set; }
    }
}
