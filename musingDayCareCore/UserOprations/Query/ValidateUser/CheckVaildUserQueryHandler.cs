using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using musingDayCareComman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace musingDayCareCore.UserOprations.Query.ValidateUser
{
    public class CheckVaildUserQueryHandler : IRequestHandler<CheckVaildUserQuery, UserInformationVM>
    {

        private readonly IMusingDayCareDbContext _dbContext;
        
        private readonly IMapper _mapper;
        public CheckVaildUserQueryHandler(IMusingDayCareDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = context;
        }


        public async Task<UserInformationVM> Handle(CheckVaildUserQuery request, CancellationToken cancellationToken)
        {
            var userData = await _dbContext.UserRecrds
                .Include(d=>d.UserDetails)
                .Include(d=>d.UserRoles)
                .FirstOrDefaultAsync(u => u.UserName == request.UserName);
            if (userData != null)
            {
                using (var passwordHMAC = new HMACSHA512(userData.PasswordSalt))
                {
                    var comptedHash = passwordHMAC.ComputeHash(System.Text.Encoding.UTF8.GetBytes(request.Password));
                    if (userData.PasswordHash.Length != comptedHash.Length)
                        return null;
                    else
                        for (int i = 0; i < comptedHash.Length; i++)
                            if (comptedHash[i] != userData.PasswordHash[i])
                                return null;
                }
                return _mapper.Map<UserInformationVM>(userData);
            }
            return null;
        }
    }
}
