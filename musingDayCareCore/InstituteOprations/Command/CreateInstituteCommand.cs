using MediatR;
using musingDayCareDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace musingDayCareCore.InstituteOprations.Command
{
    class CreateInstituteCommand : Institute, IRequest<Institute>
    {
    }
}
