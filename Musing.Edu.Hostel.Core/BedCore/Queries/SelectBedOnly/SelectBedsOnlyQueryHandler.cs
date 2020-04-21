using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.BedCore.Queries.SelectBedOnly
{
    public class SelectBedsOnlyQueryHandler : IRequestHandler<SelectBedsOnlyQuery,ICollection<Bed>>
   {
       private readonly IHostelDbContext _context;

       public SelectBedsOnlyQueryHandler(IHostelDbContext context)
       {
           _context = context;
       }

       public async Task<ICollection<Bed>> Handle(SelectBedsOnlyQuery request, CancellationToken cancellationToken)
       {
           if (request.RoomId > 0)
               return await _context.Beds.Where(x => x.RoomId == request.RoomId).ToListAsync(cancellationToken);
           return await _context.Beds.ToListAsync(cancellationToken);
       }
    }
}
