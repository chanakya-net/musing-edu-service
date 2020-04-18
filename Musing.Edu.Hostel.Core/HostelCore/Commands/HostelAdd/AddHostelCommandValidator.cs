using FluentValidation;


namespace Musing.Edu.Hostel.Core.HostelCore.Commands.HostelAdd
{
    public class AddHostelCommandValidator : AbstractValidator<AddHostelSetupCommand>
    {
        public AddHostelCommandValidator()
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("Please provide city");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Please provide address");
            RuleFor(x => x.AllowedGender).NotEmpty().WithMessage("Please provide allowed gender");
            RuleFor(x => x.ContactNumber).NotEmpty().WithMessage("Please provide contact number");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Please provide a country");
            RuleFor(x => x.MailId).NotEmpty().WithMessage("Please provide email.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please provide name");
            RuleFor(x => x.Pin).NotEmpty().WithMessage("Please provide pin code");
        }
    }
}
