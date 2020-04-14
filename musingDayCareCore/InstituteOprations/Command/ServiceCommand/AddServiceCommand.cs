using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using musingDayCareDomain;

namespace musingDayCareCore.InstituteOprations.Command.ServiceCommand
{
    public class AddServiceCommand : Service, IRequest<Service>
    {
    }
}
