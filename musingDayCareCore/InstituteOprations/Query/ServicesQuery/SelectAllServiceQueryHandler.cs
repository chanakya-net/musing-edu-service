using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using musingDayCareComman.Interfaces;
using musingDayCareDomain;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace musingDayCareCore.InstituteOprations.Query.ServicesQuery
{
    public class SelectAllServiceQueryHandler : IRequestHandler<SelectAllServiceQuery,IList<Service>>
    {

        private readonly IMusingDayCareDbContext _context;
        public SelectAllServiceQueryHandler(IMusingDayCareDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Service>> Handle(SelectAllServiceQuery request, CancellationToken cancellationToken)
        {
            var res = await _context.ServiceRecord.ToListAsync(cancellationToken);
            if (res == null)
                return null;
            return res;
        }
    }
}
