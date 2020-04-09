using MediatR;
using musingDayCareComman.Interfaces;
using musingDayCareCore.Common.Utility;
using musingDayCareDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace musingDayCareCore.UserOprations.Command.CreateNewUser
{
    public class CreateNewUserCommandHandler : IRequestHandler<CreateNewUserCommand, int>
    {
        IMusingDayCareDbContext _dbContext;

        public CreateNewUserCommandHandler(IMusingDayCareDbContext context)
        {
            _dbContext = context;
        }

        public async Task<int> Handle(CreateNewUserCommand request, CancellationToken cancellationToken)
        {
            byte[] pwdH;
            byte[] pwdS;
            Uttility.CreateHashedPassword(request.Password, out pwdH, out pwdS);
            var entity = new User()
            {
                UserName = request.userId,
                ChangePasswordAtLogin = request.ChangePasswordAtLogin,
                ContectNumber = request.ContectNumber,
                IsUserLocked = false,
                MaxLoginTryAllowed = request.MaxLoginTryAllowed,
                UserDetails = new UserDetailInformation()
                {
                    Email = request.mailId,
                    FirstName = request.FirstName,
                    LastName = request.LastName
                },
                UserRoles = request.Roles.Select(r => new Roles {
                    RoleName = r
                }).ToList(),
                PasswordHash = pwdH,
                PasswordSalt = pwdS
            };
            _dbContext.UserRecrds.Add(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }

      
    }
}
