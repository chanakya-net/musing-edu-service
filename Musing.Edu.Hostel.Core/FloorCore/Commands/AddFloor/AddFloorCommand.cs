using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Musing.Edu.Hostel.Core.FloorCore.Commands.AddFloor
{
    public class AddFloorCommand:IRequest<AddFloorVm>
    {
        public int BuildingId { get; set; }
        public string FloorName { get; set; }
    }
}
