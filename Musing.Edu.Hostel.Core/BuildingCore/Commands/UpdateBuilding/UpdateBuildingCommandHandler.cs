using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Core.BuildingCore.Commands.AddBuilding;

namespace Musing.Edu.Hostel.Core.BuildingCore.Commands.UpdateBuilding
{
    public class UpdateBuildingCommandHandler: IRequestHandler<UpdateBuildingCommand, BuildingVm>
    {

        private readonly IHostelDbContext _context;
        private readonly IMapper _mapper;

        public UpdateBuildingCommandHandler(IHostelDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<BuildingVm> Handle(UpdateBuildingCommand request, CancellationToken cancellationToken)
        {
            var res = _context.Buildings.Find(request.Id);
            if (res == null)
                return null;
            res.BuildingName = request.BuildingName;
            res.HostelSetupId = request.HostelSetupId;
            res.FloorCollection = request.FloorCollection;
            await _context.SaveChangesAsync(cancellationToken);
            return _mapper.Map<BuildingVm>(res);
        }
    }
}
