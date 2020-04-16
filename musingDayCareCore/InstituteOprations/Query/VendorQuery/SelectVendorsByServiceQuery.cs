using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using musingDayCareCore.InstituteOprations.CommonVM;

namespace musingDayCareCore.InstituteOprations.Query.VendorQuery
{
    public class SelectVendorsByServiceQuery: IRequest<VendorVM>
    {
        public int ServiceID { get; set; }
    }
}
