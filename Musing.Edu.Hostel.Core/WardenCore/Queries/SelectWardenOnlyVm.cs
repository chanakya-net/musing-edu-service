using System;
using AutoMapper;
using Musing.Edu.Hostel.Core.Common.AutoMapper;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.WardenCore.Queries
{
    public class SelectWardenOnlyVm : IMapFrom<Warden>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string ContactNumber { get; set; }
        public string MailId { get; set; }
        public  DateTime StartDate { get; set; }
        public  DateTime EndDate { get; set; }
        public Boolean CurrentStatus { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Warden, SelectWardenOnlyVm>();
        }
    }
}
