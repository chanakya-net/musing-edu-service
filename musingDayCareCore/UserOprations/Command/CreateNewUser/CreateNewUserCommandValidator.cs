using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace musingDayCareCore.UserOprations.Command.CreateNewUser
{
    public class CreateNewUserCommandValidator : AbstractValidator<CreateNewUserCommand>
    {
        public CreateNewUserCommandValidator()
        {
            RuleFor(u => u.userId).NotEmpty().WithMessage(@"User name can not empty.");
            RuleFor(u => u.FirstName).NotEmpty().WithMessage(@"First name can not empty.");
            RuleFor(u => u.LastName).NotEmpty().WithMessage(@"Last name can not empty.");
            RuleFor(u => u.Password).NotEmpty().WithMessage(@"Password can not empty.");
            RuleFor(u => u.ConfirmPassword).Equal(x => x.Password).WithMessage(@"Password does not match.");
            //RuleFor(u => u.EmailId).EmailAddress().WithMessage(@"Please enter a valid email address.");
            RuleFor(u => u.ContactNumber).NotEmpty().WithMessage(@"Contact number cannot be empty");
            RuleForEach(u => u.Roles).NotEmpty().WithMessage(@"Roles can not be empty.");
            RuleFor(u => u.ChangePasswordAtLogin).NotEmpty().WithMessage(@"Please provide if user need to change the password at login.");
            RuleFor(u => u.MaxLoginTryAllowed).NotEmpty().WithMessage(@"Please provide a value that will be used to lockout user after invalid try");
        }
    }
}
