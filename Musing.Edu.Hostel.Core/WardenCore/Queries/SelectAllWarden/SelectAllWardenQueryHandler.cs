using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Musing.edu.Hostel.Common.Interfaces;

namespace Musing.Edu.Hostel.Core.WardenCore.Queries.SelectAllWarden
{
    public class SelectAllWardenQueryHandler : IRequestHandler<SelectAllWardenQuery,ICollection<SelectWardenOnlyVm>>
    {
        private readonly IHostelDbContext _context;
        private readonly IMapper _mapper;

        public SelectAllWardenQueryHandler(IHostelDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ICollection<SelectWardenOnlyVm>> Handle(SelectAllWardenQuery request, CancellationToken cancellationToken)
        {
            var res = await _context.Wardens.Where(x=> x.CurrentStatus ==request.isActive).ProjectTo<SelectWardenOnlyVm>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            return res;
        }
    }
}
