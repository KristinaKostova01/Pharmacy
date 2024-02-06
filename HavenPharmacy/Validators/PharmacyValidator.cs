using FluentValidation;
using HavenPharmacy.Models.Request;

namespace HavenPharmacy.Validators
{
    public class PharmacyValidator : AbstractValidator<AddProductRequest>
    {
        public PharmacyValidator()
        {
            RuleFor(request => request.Name).NotEmpty().WithMessage("Product name is required.");
            RuleFor(request => request.Price).GreaterThan(0).WithMessage("Price must be greater than 0.");
            RuleFor(request => request.QuantityInStock).GreaterThan(0).WithMessage("QuantityInStock must be greater than 0.");
        }
    }
}
