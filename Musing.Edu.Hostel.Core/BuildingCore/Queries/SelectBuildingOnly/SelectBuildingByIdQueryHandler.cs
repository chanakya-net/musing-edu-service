using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using System.Linq;
using AutoMapper.QueryableExtensions;

namespace Musing.Edu.Hostel.Core.BuildingCore.Queries.SelectBuildingOnly
{
    public class SelectBuildingByIdQueryHandler: IRequestHandler<SelectBuildingByIdQuery,SelectBuildingVm>
    {
        private readonly IHostelDbContext _context;
        private readonly IMapper _mapper;

        public SelectBuildingByIdQueryHandler(IHostelDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<SelectBuildingVm> Handle(SelectBuildingByIdQuery request, CancellationToken cancellationToken)
        {
            var res = _mapper.Map<SelectBuildingVm>(_context.Buildings.Find(request.BuildingId));
            return res;

        }
    }
}
