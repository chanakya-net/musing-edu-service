using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using musingDayCareDomain;

namespace musingDayCareCore.InstituteOprations.Query.ServicesQuery
{
    public class SelectAllServiceQuery : Service, IRequest<IList<Service>>
    {
    }
}
