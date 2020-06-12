using AutoMapper;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace Musing.Edu.Hostel.Core.HostelCore.Commands.HostelAdd
{
    public class AddHostelCommandHandler: IRequestHandler<AddHostelCommand,HostelViewModelWithoutDetails>
    {
        private readonly IHostelDbContext _context;
        private readonly IMapper _mapper;

        public AddHostelCommandHandler(IHostelDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<HostelViewModelWithoutDetails> Handle(AddHostelCommand request, CancellationToken cancellationToken)
        {
            var data = new HostelSetup
            {
                State = request.State,
                City = request.City,
                Pin = request.Pin,
                Address = request.Address,
                AllowedGender = request.AllowedGender,
                ContactNumber = request.ContactNumber,
                MailId = request.MailId,
                Name = request.Name
            };
            
            await _context.Hostels.AddAsync(data, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            
            return _mapper.Map<HostelViewModelWithoutDetails>(data);
        }
    }
}
