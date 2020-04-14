using Microsoft.EntityFrameworkCore;
using musingDayCareComman.Interfaces;
using musingDayCareDomain;
using System.Threading;
using System.Threading.Tasks;

namespace musingDayCareDataBase
{
    public class MusingDayCareDbContext : DbContext, IMusingDayCareDbContext
    {
        public DbSet<User> UserRecrds { get; set; }
        public DbSet<Institute> InstituteRecord { get; set; }
        public DbSet<Service> ServiceRecord { get ; set ; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }


        public MusingDayCareDbContext(DbContextOptions<MusingDayCareDbContext> options)
         : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-U0J3L7T\DEVSQL;Database=musingDayCareDB;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MusingDayCareDbContext).Assembly);
        }
    }
}
