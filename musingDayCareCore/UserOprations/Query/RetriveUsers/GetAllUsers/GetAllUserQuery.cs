using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace musingDayCareCore.UserOprations.Query.RetriveUsers.GetAllUsers
{
    public class GetAllUserQuery : IRequest<IList<UserVM>>
    {
    }
}
