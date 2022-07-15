using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Clients.Commands.CreateClientCommad
{
    public class CreateClientCommandValidator : AbstractValidator<CreateClientCommand>
    {
        public CreateClientCommandValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("{PropertyName} can be empty")
                .MaximumLength(80).WithMessage("{PropertyName} can has more {MaxLength} chars");

            RuleFor(c => c.LastName)
                .NotEmpty().WithMessage("{PropertyName} can be empty")
                .MaximumLength(80).WithMessage("{PropertyName} can has more {MaxLength} chars");

            RuleFor(c => c.BirthDate)
                .NotEmpty().WithMessage("BirthDate can be empty");

            RuleFor(c => c.Phone)
                .NotEmpty().WithMessage("Phone Number can be empty")
                .Matches(@"^\d{4}-\d{4}$").WithMessage("Phone number incorrect format 000-0000")
                .MaximumLength(9).WithMessage("{PropertyName} can has more {MaxLength} chars");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Email can be empty")
                .EmailAddress().WithMessage("{PropertyName} incorrect format")
                .MaximumLength(100).WithMessage("{PropertyName} can has more {MaxLength} chars");

            RuleFor(c => c.Address)
                .NotEmpty().WithMessage("{PropertyName} can be empty")
                .MaximumLength(120).WithMessage("{PropertyName} can has more {MaxLength} chars");
        }
    }
}
