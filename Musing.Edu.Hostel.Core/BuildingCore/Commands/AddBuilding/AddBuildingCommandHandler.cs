using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;

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
            var building = new Building();
            building.BuildingName = request.BuildingName;
            building.HostelSetupId = request.HostelSetupId;
            _context.Buildings.Add(building);
            await _context.SaveChangesAsync(cancellationToken);
            var vm =_mapper.Map<BuildingVm>(building);
            return vm;

        }
    }
}
