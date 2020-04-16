using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using musingDayCareComman.Interfaces;
using musingDayCareCore.InstituteOprations.CommonVM;
using musingDayCareDomain;

namespace musingDayCareCore.InstituteOprations.Command.VendorCommand
{
    public class AddVendorCommandHandler : IRequestHandler<AddVendorCommand, VendorVM>
    {
        private readonly IMusingDayCareDbContext _context;
        public AddVendorCommandHandler(IMusingDayCareDbContext context)
        {
            _context = context;
        }
        public async Task<VendorVM> Handle(AddVendorCommand request, CancellationToken cancellationToken)
        {
            var data = new Vendor()
            {
                Address = request.Address,
                City = request.City,
                ContactNumbers = request.ContactNumbers,
                MailId = request.MailId,
                Name = request.Name,
                Pin = request.Pin,
            };
            foreach(var v in request.ServicesProvided)
            {
                data.ServicesProviede.Add(new VendorAndServices() { 
                    //ServiceDetails = v,
                    ServiceId=v.Id,
                    //VendorDetails = data,
                    VendorID = data.Id
                });
            }
            _context.VendorRecord.Add(data);
            await _context.SaveChangesAsync(cancellationToken);
            return request;
        }
    }
}
