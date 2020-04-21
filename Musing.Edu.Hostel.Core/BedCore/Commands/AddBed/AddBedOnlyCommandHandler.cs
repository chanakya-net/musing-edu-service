using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.BedCore.Commands.AddBed
{
    public class AddBedOnlyCommandHandler : IRequestHandler<AddBedOnlyCommand,Bed>
    {
        private readonly IHostelDbContext _context;

        public AddBedOnlyCommandHandler(IHostelDbContext context)
        {
            _context = context;
        }

        public async Task<Bed> Handle(AddBedOnlyCommand request, CancellationToken cancellationToken)
        {
            var noOfAllowedBedsInRoom = _context.Rooms.Find(request.RoomId).NumberOfBeds;
            var currentBedCount = _context.Beds.Count(x => x.RoomId == request.RoomId);
            if (currentBedCount >= noOfAllowedBedsInRoom)
            {
                return null;
            }

            var data = new Bed()
            {
                RoomId = request.RoomId,
                BedName = request.BedName,
                Charge = request.Charge,
                ChargeOccurencePeriod = request.ChargeOccurencePeriod,
                ChargeOccurencePeriodType = request.ChargeOccurencePeriodType,
                IsOccupantStaff = request.IsOccupantStaff,
                IsOccupied = request.IsOccupied
            };
            await _context.SaveChangesAsync(cancellationToken);
            return data;
        }
    }
}
