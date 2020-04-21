using MediatR;
using Musing.Edu.Common.Types;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.BedCore.Commands.AddBed
{
    public class AddBedOnlyCommand : IRequest<Bed>
    {
        public int RoomId { get; set; }
        public string BedName { get; set; }
        public decimal Charge { get; set; }
        public bool IsOccupied { get; set; }
        public bool IsOccupantStaff { get; set; }
        public ChangeType ChargeOccurencePeriodType { get; set; }
        public int ChargeOccurencePeriod { get; set; }
    }
}
