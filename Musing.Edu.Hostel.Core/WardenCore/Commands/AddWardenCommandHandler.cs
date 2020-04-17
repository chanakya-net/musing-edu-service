using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Core.WardenCore;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.WardenCore.Commands
{
    public class AddWardenCommandHandler: IRequestHandler<AddWardenCommand,WardenDetailViewData>
    {

        private readonly IHostelDbContext _context;

        public AddWardenCommandHandler(IHostelDbContext context)
        {
            _context = context;
        }
        public async Task<WardenDetailViewData> Handle(AddWardenCommand request, CancellationToken cancellationToken)
        {
            var res = new Warden()
            {
                Name = request.Name,
                Address = request.Address,
                City = request.City,
                ContactNumber = request.ContactNumber,
                MailId = request.MailId,
                Pin = request.Pin
            };
            _context.Wardens.Add(res);
            await _context.SaveChangesAsync(cancellationToken);
            return (request);
        }
    }
}
