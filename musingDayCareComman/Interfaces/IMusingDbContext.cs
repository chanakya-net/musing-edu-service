using Microsoft.EntityFrameworkCore;
using musingDayCareDomain;
using System.Threading;
using System.Threading.Tasks;

namespace musingDayCareComman.Interfaces
{
    public interface IMusingDayCareDbContext
    {
        DbSet<User> UserRecrds { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
