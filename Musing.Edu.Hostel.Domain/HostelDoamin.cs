using System;
using System.Collections.Generic;
using System.Text;
using Musing.Edu.Common.Types;
namespace Musing.Edu.Hostel.Domain
{
    public class Bed
    {
        public int Id { get; set; }
        public virtual int RoomId { get; set; }
        public string BedName { get; set; }
        public decimal Charge { get; set; }
        public ChangeType ChargeOccurancePeriodType { get; set; }
        public int ChargeOccurancePeriod { get; set; }
    }

    public class Room
    {
        public int Id { get; set; }
        public virtual int FloorId { get; set; }
        public string RoomName { get; set; }
        public virtual ICollection<Bed> BedCollection { get; set; }
    }

    public class Floor
    {
        public int Id { get; set; }
        public virtual int BuildingId { get; set; }
        public string FloorName { get; set; }
        public virtual ICollection<Room> RoomCollection { get; set; }
    }

    public class Building
    {
        public int Id { get; set; }
        public string BuildingName { get; set; }
        public virtual ICollection<Floor> FloorCollection { get; set; }
    }

    public class Hostel
    {
        public int Id { get; set; }
        public HostelGenralInformation GenralInformation { get; set; }
        public Gender AllowedGender { get; set; }


    }

    public class HostelGenralInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string State { get; set; }
        public string Countery { get; set; }
        public string ContectNumber { get; set; }
        public string MailId { get; set; }

    }

    public class warden
    {
        //public
    }

}
