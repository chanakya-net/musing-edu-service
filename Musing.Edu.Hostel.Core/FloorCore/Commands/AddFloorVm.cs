using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Musing.Edu.Hostel.Core.Common.AutoMapper;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.FloorCore.Commands
{
    public class AddFloorVm : IMapFrom<Floor>
    {
        public int Id { get; set; }
        public virtual int BuildingId { get; set; }
        public string FloorName { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Floor, AddFloorVm>();
        }
    }
}
