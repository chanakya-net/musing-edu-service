using System.Collections.Generic;
using MediatR;
using Musing.Edu.Hostel.Core.BuildingCore.Commands.AddBuilding;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.BuildingCore.Commands.UpdateBuilding
{
    public class UpdateBuildingCommand: IRequest<BuildingVm>
    {
        public int Id { get; set; }
        public int HostelSetupId { get; set; }
        public string BuildingName { get; set; }
        public virtual ICollection<Floor> FloorCollection { get; set; }
    }
}
