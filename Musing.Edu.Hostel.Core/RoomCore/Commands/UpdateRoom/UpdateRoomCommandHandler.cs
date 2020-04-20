using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.RoomCore.Commands.UpdateRoom
{
    public class UpdateRoomCommandHandler:IRequestHandler<UpdateRoomCommand,Room>
    {
        private readonly IHostelDbContext _context;

        public UpdateRoomCommandHandler(IHostelDbContext context)
        {
            _context = context;
        }

        public async Task<Room> Handle(UpdateRoomCommand request, CancellationToken cancellationToken)
        {
            var res = await _context.Rooms.FindAsync(request.Id);
            if (res == null)
                return res;
            res.FloorId = request.FloorId;
            res.RoomName = request.RoomName;
            res.BedCollection = request.BedCollection;
            await _context.SaveChangesAsync(cancellationToken);
            return res;
        }
    }
}
