using System;
using System.Collections.Generic;
using System.Text;

namespace musingDayCareDomain
{
    public class Institute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string Website { get; set; }
        public string ContactNumbers { get; set; }
        public string MailId { get; set; }
        public DateTime EstablishedOn { get; set; }
        public AcceptedGender AllowedGender { get; set; }
    }

}
