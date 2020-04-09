using MediatR;
using System.Collections.Generic;

namespace musingDayCareCore.UserOprations.Command.UpdateUser
{
    public class UpddateUserCommand : IRequest<UserVM>
    {
        public string userId { get; set; }
        public string mailId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassowrd { get; set; }
        public IList<string> Roles { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContectNumber { get; set; }
        public int MaxLoginTryAllowed { get; set; }
        public bool ChangePasswordAtLogin { get; set; }
    }
}
