using AutoMapper;
using musingDayCareCore.Common.AutoMapper;
using musingDayCareDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace musingDayCareCore.UserOprations
{
    public class UserVM : IMapFrom<User>
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailId { get; set; }
        public string ContactNumber { get; set; }
        public bool IsUserLocked { get; set; }
        public int WrongLoginTries { get; set; }
        public List<string> Roles { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<User, UserVM>().ForMember(d => d.UserName, opt => opt.MapFrom(s => s.UserName))
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.UserDetails.FirstName))
                .ForMember(d => d.LastName, opt => opt.MapFrom(s => s.UserDetails.LastName))
                .ForMember(d=> d.MailId, opt => opt.MapFrom(s=> s.UserDetails.Email))
                .ForMember(d=> d.ContactNumber, opt => opt.MapFrom(s=>s.ContactNumber))
                .ForMember(d=> d.IsUserLocked, opt => opt.MapFrom(s=>s.IsUserLocked))
                .ForMember(d => d.WrongLoginTries, opt=>opt.MapFrom(s=>s.WrongLoginTries))
                .ForMember(d => d.Roles, opt => opt.MapFrom(d => d.UserRoles.Select(x => x.RoleName)));

        }

    }
}
