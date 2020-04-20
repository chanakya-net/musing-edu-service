using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.WardenCore.Commands.WardenUpdate
{
    public class UpdateWardenCommandHandler : IRequestHandler<UpdateWardenCommand, Warden>
    {
        private readonly IHostelDbContext _context;
        public UpdateWardenCommandHandler(IHostelDbContext context)
        {
            _context = context;
        }
        public async Task<Warden> Handle(UpdateWardenCommand request, CancellationToken cancellationToken)
        {
            var res = _context.Wardens.Find(request.Id);
            if (res == null)
                return null;
            res.City = request.City;
            res.Address = request.Address;
            res.ContactNumber = request.ContactNumber;
            res.CurrentStatus = request.CurrentStatus;
            res.EndDate = request.EndDate;
            res.MailId = request.MailId;
            res.Name = request.Name;
            res.Pin = request.Pin;
            res.StartDate = request.StartDate;
            res.WardenAndHostelRelations = request.WardenAndHostelRelations;
            await _context.SaveChangesAsync(cancellationToken);
            return res;
        }
    }
}
