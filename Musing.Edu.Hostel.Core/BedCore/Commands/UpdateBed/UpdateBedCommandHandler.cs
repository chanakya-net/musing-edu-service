using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.BedCore.Commands.UpdateBed
{
    public class UpdateBedCommandHandler: IRequestHandler<UpdateBedCommand,Bed>
    {
        private readonly IHostelDbContext _context;
        

        public UpdateBedCommandHandler(IHostelDbContext context, IMapper mapper)
        {
            _context = context;
        }

        public async Task<Bed> Handle(UpdateBedCommand request, CancellationToken cancellationToken)
        {
            var res = await _context.Beds.FindAsync(request.Id);
            if (res == null)
                return null;
            res.BedName = request.BedName;
            res.Charge = request.Charge;
            res.IsOccupied = request.IsOccupied;
            res.IsOccupantStaff = request.IsOccupantStaff;
            res.ChargeOccurencePeriodType = request.ChargeOccurencePeriodType;
            res.ChargeOccurencePeriod = request.ChargeOccurencePeriod;
            res.RoomId = request.RoomId;
            await _context.SaveChangesAsync(cancellationToken);
            return res;
        }
    }
}
