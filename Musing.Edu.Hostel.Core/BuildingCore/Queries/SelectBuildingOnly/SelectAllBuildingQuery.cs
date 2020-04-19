using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Musing.Edu.Hostel.Core.BuildingCore.Queries.SelectBuildingOnly
{
    public class SelectAllBuildingQuery: IRequest<ICollection<SelectBuildingVm>>
    {
       public int HostelId { get; set; }
    }
}
