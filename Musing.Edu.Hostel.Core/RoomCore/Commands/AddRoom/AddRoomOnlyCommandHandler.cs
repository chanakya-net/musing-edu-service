using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.RoomCore.Commands.AddRoom
{
    public class AddRoomOnlyCommandHandler : IRequestHandler<AddRoomOnlyCommand,Room>
    {
        private readonly IHostelDbContext _context;

        public AddRoomOnlyCommandHandler(IHostelDbContext context)
        {
            _context = context;
        }

        public async Task<Room> Handle(AddRoomOnlyCommand request, CancellationToken cancellationToken)
        {
            var data = new Room()
            {
                FloorId = request.FloorId,
                RoomName = request.RoomName
            };
            await _context.Rooms.AddAsync(data, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return data;
        }
    }
}
