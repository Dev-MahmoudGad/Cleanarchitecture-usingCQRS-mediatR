using CleanArchitecture.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Appllication.Features.Address.Command.CreateAddress
{
    public class CreateAddressCommandValidator : AbstractValidator<CreateAddressCommand>
    {
        public CreateAddressCommandValidator()
        {

            RuleFor(address => address.CityId)
                .NotEmpty().WithMessage("City is required.");

            RuleFor(address => address.Street)
                .NotEmpty().WithMessage("Street is required.")
                .MaximumLength(200).WithMessage("Street can be a maximum of 200 characters.");

            RuleFor(address => address.BuildingNumber)
                .NotEmpty().WithMessage("Building Number is required.");

            RuleFor(address => address.FlatNumber)
                .NotEmpty().WithMessage("Building Number is required.");
        }

    }
}
