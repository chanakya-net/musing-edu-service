using System.Collections.Generic;
using MediatR;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.RoomCore.Queries.SelectRoomOnly
{
    public  class SelectAllRoomsQuery : IRequest<ICollection<Room>>
    {
        public int FloorIdSearch { get; set; }
    }
}
