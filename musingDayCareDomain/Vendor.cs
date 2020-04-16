using System;
using System.Collections.Generic;
using System.Text;

namespace musingDayCareDomain
{
    public class Vendor
    {
        public Vendor()
        {
            ServicesProviede = new List<VendorAndServices>();
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string ContactNumbers { get; set; }
        public string MailId { get; set; }
        public ICollection<VendorAndServices> ServicesProviede {get;set;}
    }

    public class VendorAndServices
    {
        public int Id { get; set; }
        public int VendorID { get; set; }
        //public virtual Vendor VendorDetails { get; set; }

        public int ServiceId { get; set; }
        //public virtual Service ServiceDetails { get; set; }
    }
}
