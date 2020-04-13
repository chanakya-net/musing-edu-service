using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using musingDayCareDomain;

namespace musingDayCareCore.InstituteOprations.Command
{
    public class UpdateInstituteCommand : Institute, IRequest<Institute>
    {
    }
}
