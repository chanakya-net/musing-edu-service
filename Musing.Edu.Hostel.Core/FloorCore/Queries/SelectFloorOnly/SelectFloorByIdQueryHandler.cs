using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.FloorCore.Queries.SelectFloorOnly
{
    public class SelectFloorByIdQueryHandler: IRequestHandler<SelectFloorByIdQuery,Floor>
    {
        private readonly IHostelDbContext _context;

        public SelectFloorByIdQueryHandler(IHostelDbContext context)
        {
            _context = context;
        }

        public async Task<Floor> Handle(SelectFloorByIdQuery request, CancellationToken cancellationToken)
        {
            var res = _context.Floors.Find(request.FloorId);
            return res;
        }
    }
}
