using FluentValidation;

namespace Musing.Edu.Hostel.Core.WardenCore.Commands.WardenAdd
{
    public class AddWardenCommandValidator: AbstractValidator<AddWardenCommand>
    {
        public AddWardenCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please provide name.");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Please provide address");
            RuleFor(x => x.City).NotEmpty().WithMessage("Please provide city.");
            RuleFor(x => x.ContactNumber).NotEmpty().WithMessage("Please provide contact number.");
            RuleFor(x => x.MailId).NotEmpty().WithMessage("Please provide email id");
            RuleFor(x => x.Pin).NotEmpty().WithMessage("Please provide pin code.");
        }
    }
}
