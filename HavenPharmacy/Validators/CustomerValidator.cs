using FluentValidation;
using HavenPharmacy.Models;

namespace HavenPharmacy.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Name).NotEmpty().WithMessage("Name is required.");
            RuleFor(customer => customer.Address).NotEmpty().WithMessage("Address is required.");
            RuleFor(customer => customer.PhoneNumber).NotEmpty().WithMessage("PhoneNumber is required.");
        }
    }
}
