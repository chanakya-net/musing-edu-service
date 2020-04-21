using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.BedCore.Queries.SelectBedOnly
{
    public class SelectBedByIdQueryHandler: IRequestHandler<SelectBedByIdQuery,Bed>
   {
       private readonly IHostelDbContext _context;

       public SelectBedByIdQueryHandler(IHostelDbContext context)
       {
           _context = context;
       }

       public async Task<Bed> Handle(SelectBedByIdQuery request, CancellationToken cancellationToken)
       {
           return await _context.Beds.FindAsync(request.BedId);
       }
    }
}
