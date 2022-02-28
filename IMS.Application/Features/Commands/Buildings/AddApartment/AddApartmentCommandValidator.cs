using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Application.Features.Commands.Buildings.AddApartment
{
    public class AddApartmentCommandValidator : AbstractValidator<AddApartmentCommand>
    {
        public AddApartmentCommandValidator()
        {
            RuleFor(fu => fu.Number).GreaterThan(0).NotNull().WithMessage("{Number} is required.");
            RuleFor(ru => ru.FloorNumber).GreaterThan(0).NotNull().WithMessage("{FloorNumber} is required.");
        }
    }
}
