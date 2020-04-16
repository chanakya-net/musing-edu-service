using System;
using System.Collections.Generic;
using System.Text;
using musingDayCareDomain;

namespace musingDayCareCore.InstituteOprations.CommonVM
{
    public class VendorVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string ContactNumbers { get; set; }
        public string MailId { get; set; }
        public ICollection<Service> ServicesProvided { get; set; }
    }
}
