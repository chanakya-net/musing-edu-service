using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.FloorCore.Commands.AddFloor
{
    public class AddFloorCommandHandler: IRequestHandler<AddFloorCommand,AddFloorVm>
    {
        private readonly IHostelDbContext _context;
        private readonly IMapper _mapper;

        public AddFloorCommandHandler(IHostelDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<AddFloorVm> Handle(AddFloorCommand request, CancellationToken cancellationToken)
        {
            var data = new Floor()
            {
                BuildingId = request.BuildingId,
                FloorName = request.FloorName
            };
            _context.Floors.Add(data);
            await _context.SaveChangesAsync(cancellationToken);
            return _mapper.Map<AddFloorVm>(data);
        }
    }
}
