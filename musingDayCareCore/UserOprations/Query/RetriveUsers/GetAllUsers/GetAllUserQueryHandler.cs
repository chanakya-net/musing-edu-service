using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using musingDayCareComman.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace musingDayCareCore.UserOprations.Query.RetriveUsers.GetAllUsers
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, IList<UserVM>>
    {
        private readonly IMusingDayCareDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetAllUserQueryHandler(IMusingDayCareDbContext contxet, IMapper map)
        {
            _dbContext = contxet;
            _mapper = map;
        }
       
        public async Task<IList<UserVM>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var users = await _dbContext.UserRecrds.Include(d => d.UserDetails).Include(d => d.UserRoles).ProjectTo<UserVM>(_mapper.ConfigurationProvider).ToListAsync();
            return users;
        }
    }
}
