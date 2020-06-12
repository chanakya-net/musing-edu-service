using MediatR;
using Musing.Edu.Common.Types;

namespace Musing.Edu.Hostel.Core.HostelCore.Commands.HostelAdd
{
    public class AddHostelCommand  : IRequest<HostelViewModelWithoutDetails>
    {
        public Gender AllowedGender { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ContactNumber { get; set; }
        public string MailId { get; set; }
    }
}
