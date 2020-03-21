using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using musingDayCareDomain;
using musingDayCareComman.Interfaces;
using System.Threading.Tasks;
using System.Threading;

namespace musingDayCareCore.UserOprations.Command
{
    public class RegisterUserCommand : IRequest<int>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public IEnumerable<Roles> UserRoles { get; set; }
        public UserDetailInformation UserDetails { get; set; }

      
    }
}
