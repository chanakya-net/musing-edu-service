using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Musing.Edu.Hostel.Core.BuildingCore.Queries.SelectBuildingOnly
{
    public class SelectBuildingByIdCommand : IRequest<SelectBuildingVm>
    {
        public int BuildingId { get; set; }
    }
}
