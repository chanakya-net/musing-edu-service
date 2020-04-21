using System.Collections.Generic;
using MediatR;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.BedCore.Queries.SelectBedOnly
{
    public class SelectBedsOnlyQuery: IRequest<ICollection<Bed>>
    {
        public int RoomId { get; set; }
    }
}
