using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace musingDayCareCore.UserOprations.Command.UpdateUser
{
    public class UpdateUserCommandValidator : AbstractValidator<UpddateUserCommand>
    {
        public UpdateUserCommandValidator()
        {
            RuleFor(u => u.userId).NotEmpty().WithMessage(@"User name can not empty.");
            RuleFor(u => u.FirstName).NotEmpty().WithMessage(@"First name can not empty.");
            RuleFor(u => u.LastName).NotEmpty().WithMessage(@"Last name can not empty.");
            RuleFor(u => u.ConfirmPassowrd).Equal(x => x.Password).WithMessage(@"Password does not match.");
            //RuleFor(u => u.EmailId).EmailAddress().WithMessage(@"Please enter a valid email address.");
            RuleFor(u => u.ContactNumber).NotEmpty().WithMessage(@"Contact number cannot be empty");
            RuleForEach(u => u.Roles).NotEmpty().WithMessage(@"Roles can not be empty.");
        }
    }
}
