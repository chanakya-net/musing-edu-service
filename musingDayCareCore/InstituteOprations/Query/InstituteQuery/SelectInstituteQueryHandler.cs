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

namespace musingDayCareCore.InstituteOprations.Query.InstituteQuery
{
    public class SelectInstituteQueryHandler : IRequestHandler<SelectInstituteQuery, Institute>
    {

        private readonly IMusingDayCareDbContext _context;

        public SelectInstituteQueryHandler(IMusingDayCareDbContext context)
        {
            _context = context;
        }

        public async Task<Institute> Handle(SelectInstituteQuery request, CancellationToken cancellationToken)
        {
            var result = await (from d in _context.InstituteRecord
                                where d.Id > 0 orderby d.Id descending
                                select d).FirstOrDefaultAsync(cancellationToken);
            return result;
            
        }
    }
}
