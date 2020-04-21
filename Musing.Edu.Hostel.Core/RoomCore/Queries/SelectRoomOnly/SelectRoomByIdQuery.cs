using MediatR;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.RoomCore.Queries.SelectRoomOnly
{
    public class SelectRoomByIdQuery : IRequest<Room>
    {
        public int RoomId { get; set; }
    }
}
