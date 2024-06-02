using CleanArchitecture.Appllication.Features.Address.Command.CreateAddress;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(p => p.FirstName)
                .NotEmpty()
                .NotNull().WithMessage("This Field Is Required")
                .MaximumLength(20).WithMessage("Maximum Length Is 20 Char")
                .Matches(_regEx).WithMessage("Letter Only");


            RuleFor(p => p.MiddleName)
                .NotEmpty()
                .NotNull().WithMessage("This Field Is Required")
                .MaximumLength(20).WithMessage("Maximum Length Is 40 Char")
                .Matches(_regEx).WithMessage("Letter Only");


            RuleFor(p => p.MiddleName)
                .NotEmpty().NotNull().WithMessage("This Field Is Required")
                .MaximumLength(40).WithMessage("Maximum Length Is 40 Char")
                .Matches(_regEx).WithMessage("Letter Only");

            RuleFor(p => p.LastName)
                .NotEmpty().NotNull().WithMessage("This Field Is Required")
                .MaximumLength(20).WithMessage("Maximum Length Is 20 Char")
                .Matches(_regEx).WithMessage("Letter Only");

            RuleFor(p => p.BirthDate)
                .NotEmpty().NotNull().WithMessage("This Field Is Required")
                .Must(BeAtLeast20YearsOld).WithMessage("Person must be at least 20 years old.");

            RuleFor(p => p.MobileNumber)
                .NotEmpty().NotNull().WithMessage("This Field Is Required");

            RuleFor(p => p.Email)
                .NotEmpty().NotNull().WithMessage("This Field Is Required")
                .EmailAddress().WithMessage("A valid email address is required.");

            RuleForEach(user => user.Addresses).SetValidator(new CreateAddressCommandValidator());
        }

        private readonly Regex _regEx = new Regex(@"^[a-zA-Z\u0621-\u064A\s]+$");
        private bool BeAtLeast20YearsOld(DateTime birthdate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthdate.Year;
            if (birthdate.Date > today.AddYears(-age)) age--;
            return age >= 20;
        }
    }
}
