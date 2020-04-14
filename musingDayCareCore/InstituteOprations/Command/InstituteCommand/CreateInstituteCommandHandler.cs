using MediatR;
using musingDayCareComman.Interfaces;
using musingDayCareDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace musingDayCareCore.InstituteOprations.Command.InstituteCommand
{
    class CreateInstituteCommandHandler : IRequestHandler<CreateInstituteCommand, Institute>
    {
        private readonly IMusingDayCareDbContext _context;
        public CreateInstituteCommandHandler(IMusingDayCareDbContext context)
        {
            _context = context;
        }
        public async Task<Institute> Handle(CreateInstituteCommand request, CancellationToken cancellationToken)
        {
            _context.InstituteRecord.Add(request);
            await _context.SaveChangesAsync(cancellationToken);
            return request;
        }
    }
}
