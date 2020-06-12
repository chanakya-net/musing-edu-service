using AutoMapper;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace Musing.Edu.Hostel.Core.BuildingCore.Commands.AddBuilding
{
    public class AddBuildingCommandHandler: IRequestHandler<AddBuildCommand,BuildingVm>
    {

        private readonly IHostelDbContext _context;
        private readonly IMapper _mapper;

        public AddBuildingCommandHandler(IHostelDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<BuildingVm> Handle(AddBuildCommand request, CancellationToken cancellationToken)
        {
            var building = new Building
            {
                BuildingName = request.BuildingName, 
                HostelSetupId = request.HostelSetupId,
                Address = request.Address,
                City = request.City,
                ContactNumber = request.ContactNumber,
                Country = request.Country,
                MailId = request.MailId,
                Pin = request.Pin,
                State = request.State
            };
            await _context.Buildings.AddAsync(building, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            var vm =_mapper.Map<BuildingVm>(building);
            return vm;

        }
    }
}
