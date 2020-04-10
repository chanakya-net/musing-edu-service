using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace musingDayCareCore.UserOprations.Command.CreateNewUser
{
    public class CreateNewUserCommand : IRequest<int>
    {
        public string userId { get; set; }
        public string mailId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public IList<string> Roles { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public int MaxLoginTryAllowed { get; set; }
        public bool ChangePasswordAtLogin { get; set; }
    }
}
