using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using musingDayCareCore.InstituteOprations.CommonVM;
using musingDayCareDomain;

namespace musingDayCareCore.InstituteOprations.Command.VendorCommand
{
    public class AddVendorCommand : VendorVM, IRequest<VendorVM>
    {
       
    }
}
