using MediatR;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.RoomCore.Commands.AddRoom
{
    public class AddRoomOnlyCommand : IRequest<Room>
    {
        public virtual int FloorId { get; set; }
        public string RoomName { get; set; }
    }
}
