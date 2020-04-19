using AutoMapper;
using Musing.Edu.Hostel.Core.Common.AutoMapper;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.BuildingCore.Commands.AddBuilding
{
    public class BuildingVm : IMapFrom<Building>
    {
        public int Id { get; set; }
        public int HostelSetupId { get; set; }
        public string BuildingName { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Building, BuildingVm>();
        }
    }
}
