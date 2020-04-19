using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using System.Linq;
using  AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Musing.edu.Hostel.Common.Interfaces;

namespace Musing.Edu.Hostel.Core.BuildingCore.Queries.SelectBuildingOnly
{
    public class SelectAllBuildingQueryHandler : IRequestHandler<SelectAllBuildingQuery,ICollection<SelectBuildingVm>>
    {
        private readonly IHostelDbContext _context;
        private readonly IMapper _mapper;

        public SelectAllBuildingQueryHandler(IHostelDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ICollection<SelectBuildingVm>> Handle(SelectAllBuildingQuery request, CancellationToken cancellationToken)
        {
            var res = new List<SelectBuildingVm>();
            if (request.HostelId > 0)
            {
                res = await _context.Buildings.Where(x=> x.HostelSetupId == request.HostelId).ProjectTo<SelectBuildingVm>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            }
            else
            {
                res = await _context.Buildings.ProjectTo<SelectBuildingVm>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);    
            }
            
            return res;
        }
    }
}
