using System;
using System.Collections.Generic;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.WardenCore
{
    public class WardenDetailViewData
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string ContactNumber { get; set; }
        public string MailId { get; set; }
        public  DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public  bool Status { get; set; }
        public virtual ICollection<HostelAndWardenRelations> WardenAndHostelRelations { get; set; }
    }
}
