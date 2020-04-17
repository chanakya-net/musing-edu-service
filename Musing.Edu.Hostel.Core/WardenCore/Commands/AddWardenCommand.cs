using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Musing.Edu.Hostel.Core.WardenCore;

namespace Musing.Edu.Hostel.Core.WardenCore.Commands
{
    public class AddWardenCommand : WardenDetailViewData, IRequest<WardenDetailViewData>
    {
    }
}
