using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.RoomCore.Queries.SelectRoomOnly
{
    public class SelectAllRoomsQueryHandler: IRequestHandler<SelectAllRoomsQuery,ICollection<Room>>
    {
        private readonly IHostelDbContext _context;

        public SelectAllRoomsQueryHandler(IHostelDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Room>> Handle(SelectAllRoomsQuery request, CancellationToken cancellationToken)
        {
            List<Room> res;
            if (request.FloorIdSearch > 0)
            {
                res = await _context.Rooms.Where(x => x.FloorId == request.FloorIdSearch)
                    .ToListAsync(cancellationToken);
            }
            else
            {
                res = await _context.Rooms.ToListAsync(cancellationToken);
            }
            return res;
        }
    }
}
