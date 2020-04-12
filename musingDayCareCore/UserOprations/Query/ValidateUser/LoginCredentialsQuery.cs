using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace musingDayCareCore.UserOprations.Query.ValidateUser
{
    public class LoginCredentialsQuery : IRequest<LoggedInUserVM>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
