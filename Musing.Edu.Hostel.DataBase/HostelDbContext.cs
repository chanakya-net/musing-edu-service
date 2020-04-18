using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.DataBase
{
    public class HostelDbContext : DbContext, IHostelDbContext
    {
        public DbSet<Bed> Beds { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<HostelSetup> Hostels { get; set; }
        public DbSet<Warden> Wardens { get; set; }
        public DbSet<HostelAndWardenRelations> HostelAndWardenRelations { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        public HostelDbContext(DbContextOptions<HostelDbContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-U0J3L7T\DEVSQL;Database=musingHostel;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HostelDbContext).Assembly);
        }
    }
}
