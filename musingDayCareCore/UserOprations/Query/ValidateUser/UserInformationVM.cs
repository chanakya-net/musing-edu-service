using AutoMapper;
using musingDayCareCore.Common.AutoMapper;
using musingDayCareDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace musingDayCareCore.UserOprations.Query.ValidateUser
{
    public class UserInformationVM : IMapFrom<User>
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<string> Roles { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<User, UserInformationVM>().ForMember(d => d.UserName, opt => opt.MapFrom(s => s.UserName))
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.UserDetails.FirstName))
                .ForMember(d => d.LastName, opt => opt.MapFrom(d => d.UserDetails.LastName))
                .ForMember(d => d.Roles, opt => opt.MapFrom(d => d.UserRoles.Select(x=>x.RoleName)));

        }
    }
}
