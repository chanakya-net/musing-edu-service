using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Musing.Edu.Hostel.Core.BuildingCore.Commands.AddBuilding
{
    public class AddBuildCommand: IRequest<BuildingVm>
    {
        public int HostelSetupId { get; set; }
        public string BuildingName { get; set; }
    }
}
