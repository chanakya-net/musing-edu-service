using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using musingDayCareComman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;

namespace musingDayCareCore.UserOprations.Command.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpddateUserCommand, UserVM>
    {
        private readonly IMusingDayCareDbContext _dbContext;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IMapper mapper, IMusingDayCareDbContext context)
        {
            _mapper = mapper;
            _dbContext = context;
        }

        public async Task<UserVM> Handle(UpddateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _dbContext.UserRecrds.Include(d => d.UserDetails)
                .Include(r => r.UserRoles).FirstOrDefault(x => x.UserName == request.userId);
            user.ContectNumber = request.ContectNumber;
            user.UserDetails.Email = request.mailId;
            user.UserDetails.FirstName = request.FirstName;
            user.UserDetails.LastName = request.LastName;
            user.MaxLoginTryAllowed = request.MaxLoginTryAllowed;
            user.ChangePasswordAtLogin = request.ChangePasswordAtLogin;
            await _dbContext.SaveChangesAsync(cancellationToken);
            return _mapper.Map<UserVM>(user);
        }
    }
}
