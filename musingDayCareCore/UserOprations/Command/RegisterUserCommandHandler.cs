using MediatR;
using musingDayCareComman.Interfaces;
using musingDayCareDomain;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace musingDayCareCore.UserOprations.Command
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, int>
    {
        IMediator _mediator;
        IMusingDayCareDbContext _dbContext;

        public RegisterUserCommandHandler(IMediator mediator, IMusingDayCareDbContext dbcontext)
        {
            _mediator = mediator;
            _dbContext = dbcontext;
        }

        public async Task<int> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            byte[] passwordHash, passwordSalt;
            CreateHashedPassword(request.Password, out passwordHash, out passwordSalt);

            var entity = new User()
            {
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                UserDetails = request.UserDetails,
                UserName = request.UserName,
                UserRoles = request.UserRoles
            };
            _dbContext.UserRecrds.Add(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }

        private void CreateHashedPassword(string password, out byte[] passwordHash, out byte[] passowrdSalt)
        {
            using (var passwordHMAC = new HMACSHA512())
            {
                passowrdSalt = passwordHMAC.Key;
                passwordHash = passwordHMAC.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
