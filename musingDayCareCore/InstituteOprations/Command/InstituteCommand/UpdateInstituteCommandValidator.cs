using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace musingDayCareCore.InstituteOprations.Command.InstituteCommand
{
    public class UpdateInstituteCommandValidator : AbstractValidator<UpdateInstituteCommand>
    {
        public UpdateInstituteCommandValidator()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage(@"Please provide institute name.");
            RuleFor(s => s.Address).NotEmpty().WithMessage(@"Please provide address of the institute.");
            RuleFor(s => s.AllowedGender).NotEmpty().WithMessage(@"Please provide the genders allowed in school.");
            RuleFor(s => s.City).NotEmpty().WithMessage(@"Please provide the city where institute is located.");
            RuleFor(s => s.ContactNumbers).NotEmpty().WithMessage(@"Please provide contact number of the institute");
            RuleFor(s => s.Pin).NotEmpty().WithMessage(@"Please provide pin code of the institute");
        }
    }
}
