using AutoMapper;
using Musing.Edu.Common.Types;
using Musing.Edu.Hostel.Core.Common.AutoMapper;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.HostelCore
{
    public class HostelViewModelWithoutDetails : IMapFrom<HostelSetup>
    {

        public Gender AllowedGender { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ContactNumber { get; set; }
        public string MailId { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<HostelSetup, HostelViewModelWithoutDetails>();
        }
    }
}
