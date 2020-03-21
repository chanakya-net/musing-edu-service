using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace musingDayCareCore.UserOprations.Query.ValidateUser
{
    public class CheckVaildUserQuery : IRequest<UserInformationVM>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
