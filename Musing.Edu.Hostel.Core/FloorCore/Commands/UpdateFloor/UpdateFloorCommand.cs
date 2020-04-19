using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.FloorCore.Commands.UpdateFloor
{
    public class UpdateFloorCommand: Floor,IRequest<Floor>
    {
    }
}
