using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using musingDayCareComman.Interfaces;
using musingDayCareCore.InstituteOprations.CommonVM;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace musingDayCareCore.InstituteOprations.Query.VendorQuery
{
    public class SelectVendorByServiceQuereyHandler : IRequestHandler<SelectVendorsByServiceQuery, VendorVM>
    {
        private readonly IMusingDayCareDbContext _context;
        public SelectVendorByServiceQuereyHandler(IMusingDayCareDbContext context)
        {
            _context = context;
        }
        public async Task<VendorVM> Handle(SelectVendorsByServiceQuery request, CancellationToken cancellationToken)
        {
            var vm = new VendorVM();
            var result = _context.VendorRecord.FirstOrDefault(ven => (ven.Id) == (ven.ServicesProviede.FirstOrDefault(s => s.ServiceId == request.ServiceID).VendorID));
            if(result != null)
            {
                vm.Address = result.Address;
                vm.City = result.City;
                vm.ContactNumbers = result.ContactNumbers;
                vm.Id = result.Id;
                vm.MailId = result.MailId;
                vm.Name = result.Name;
                vm.Pin = result.Pin;
            }
            return vm;
        }
    }
}
