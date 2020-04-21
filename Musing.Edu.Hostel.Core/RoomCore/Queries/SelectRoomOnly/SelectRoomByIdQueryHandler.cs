using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.RoomCore.Queries.SelectRoomOnly
{
    class SelectRoomByIdQueryHandler : IRequestHandler<SelectRoomByIdQuery,Room>
    {
        private readonly IHostelDbContext _context;

        public SelectRoomByIdQueryHandler(IHostelDbContext context)
        {
            _context = context;
        }

        public async Task<Room> Handle(SelectRoomByIdQuery request, CancellationToken cancellationToken)
        {
            var data= await _context.Rooms.FindAsync(request.RoomId);
            return data;
        }
    }
}
