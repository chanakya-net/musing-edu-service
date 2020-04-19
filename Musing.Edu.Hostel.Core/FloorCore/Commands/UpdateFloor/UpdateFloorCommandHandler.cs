using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Musing.edu.Hostel.Common.Interfaces;
using Musing.Edu.Hostel.Core.FloorCore.Commands.AddFloor;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.FloorCore.Commands.UpdateFloor
{
    public class UpdateFloorCommandHandler:IRequestHandler<UpdateFloorCommand,Floor>
    {
        private readonly IHostelDbContext _context;
        private readonly IMapper _mapper;

        public UpdateFloorCommandHandler(IHostelDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Floor> Handle(UpdateFloorCommand request, CancellationToken cancellationToken)
        {
            var res = _context.Floors.Find(request.Id);
            if (res == null)
                return res;
            res.BuildingId = request.BuildingId;
            res.FloorName = request.FloorName;
            res.RoomCollection = request.RoomCollection;
            await _context.SaveChangesAsync(cancellationToken);
            return res;
        }
    }
}
