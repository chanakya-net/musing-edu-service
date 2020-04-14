using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using musingDayCareComman.Interfaces;
using musingDayCareDomain;

namespace musingDayCareCore.InstituteOprations.Command.ServiceCommand
{
    public class AddServiceCommandHandler : IRequestHandler<AddServiceCommand, Service>
    {
        private readonly IMusingDayCareDbContext _context;
        public AddServiceCommandHandler(IMusingDayCareDbContext context)
        {
            _context = context;
        }
        public async Task<Service> Handle(AddServiceCommand request, CancellationToken cancellationToken)
        {
            Service s = new Service()
            {
                ServiceName = request.ServiceName
            };
            _context.ServiceRecord.Add(s);
            await _context.SaveChangesAsync(cancellationToken);
            return s;
        }
    }
}
