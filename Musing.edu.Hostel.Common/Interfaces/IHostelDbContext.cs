using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Musing.Edu.Hostel.Domain;

namespace Musing.edu.Hostel.Common.Interfaces
{
    public interface IHostelDbContext
    {
        DbSet<Bed> Beds { get; set; }
        DbSet<Room> Rooms { get; set; }
        DbSet<Floor> Floors { get; set; }
        DbSet<Building> Buildings { get; set; }
        DbSet<HostelSetup> Hostels { get; set; }
        DbSet<Warden> Wardens { get; set; }
        DbSet<HostelAndWardenRelations> HostelAndWardenRelations { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
