using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.HostelCore.Commands.HostelAdd
{
    public class AddHostelSetupCommandHandler: IRequestHandler<AddHostelSetupCommand, HostelSetup>
    {
        private readonly IHostelDbContext _context;

        public AddHostelSetupCommandHandler(IHostelDbContext context)
        {
            _context = context;
        }
        public async Task<HostelSetup> Handle(AddHostelSetupCommand request, CancellationToken cancellationToken)
        {
            var data = new HostelSetup()
            {
                City = request.City,
                MailId = request.MailId,
                Name = request.Name,
                Pin = request.Pin,
                ContactNumber = request.ContactNumber,
                Address = request.Address,
                AllowedGender = request.AllowedGender,
                Country = request.Country,
                State = request.State,
                HostelAndWarden = request.HostelAndWarden,
                BuildingCollection = request.BuildingCollection
            };
            _context.Hostels.Add(data);
            await _context.SaveChangesAsync(cancellationToken);
            return data;
        }
    }
}
