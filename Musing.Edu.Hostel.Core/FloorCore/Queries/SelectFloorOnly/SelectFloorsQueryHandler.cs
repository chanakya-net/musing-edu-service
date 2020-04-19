using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;
using System.Linq;

namespace Musing.Edu.Hostel.Core.FloorCore.Queries.SelectFloorOnly
{
    public class SelectFloorsQueryHandler: IRequestHandler<SelectFloorsQuery,ICollection<Floor>>
    {
        private readonly IHostelDbContext _context;
        public SelectFloorsQueryHandler(IHostelDbContext context, IMapper mapper)
        {
            _context = context;
        }

        public async Task<ICollection<Floor>> Handle(SelectFloorsQuery request, CancellationToken cancellationToken)
        {
            var res =  new List<Floor>();
            if (request.SelectedBuildingId <= 0)
            {
                res = await _context.Floors.ToListAsync(cancellationToken);
            }
            else
            {
                res = await _context.Floors.Where(x => x.BuildingId == request.SelectedBuildingId)
                    .ToListAsync(cancellationToken);
            }
            return res;
        }
    }
}
