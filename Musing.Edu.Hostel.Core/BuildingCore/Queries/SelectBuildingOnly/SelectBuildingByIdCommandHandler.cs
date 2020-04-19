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
    public class SelectBuildingByIdCommandHandler: IRequestHandler<SelectBuildingByIdCommand,SelectBuildingVm>
    {
        private readonly IHostelDbContext _context;
        private readonly IMapper _mapper;

        public SelectBuildingByIdCommandHandler(IHostelDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<SelectBuildingVm> Handle(SelectBuildingByIdCommand request, CancellationToken cancellationToken)
        {
            var res = _mapper.Map<SelectBuildingVm>(_context.Buildings.Find(request.BuildingId));
            return res;

        }
    }
}
