using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.FloorCore.Queries.SelectFloorOnly
{
    public class SelectFloorsQuery: IRequest<ICollection<Floor>>
    {
        public int SelectedBuildingId { get; set; }
    }
}
