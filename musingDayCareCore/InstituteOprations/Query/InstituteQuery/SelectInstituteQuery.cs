using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using musingDayCareDomain;

namespace musingDayCareCore.InstituteOprations.Query.InstituteQuery
{
    public class SelectInstituteQuery : IRequest<Institute>
    {
    }
}
