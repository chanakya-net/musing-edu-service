using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using musingDayCareDomain;

namespace musingDayCareCore.InstituteOprations.Command.InstituteCommand
{
    public class UpdateInstituteCommand : Institute, IRequest<Institute>
    {
    }
}
