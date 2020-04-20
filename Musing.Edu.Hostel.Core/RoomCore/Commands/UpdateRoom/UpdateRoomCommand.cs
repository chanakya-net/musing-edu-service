using MediatR;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.RoomCore.Commands.UpdateRoom
{
    public class UpdateRoomCommand: Room,IRequest<Room>
    {
    }
}
