using Para.Data.Domain;
using FluentValidation;
using Para.Schema;

namespace Para.Bussiness.Validation
{
    public class CustomerAddressRequestValidator : AbstractValidator<CustomerAddressRequest>
    {
        public CustomerAddressRequestValidator()
        {
            RuleFor(request => request.CustomerId).NotEmpty().WithMessage("Customer ID is required.");
            RuleFor(request => request.Country).NotEmpty().WithMessage("Country is required.").MaximumLength(50).WithMessage("Country must not exceed 50 characters.");
            RuleFor(request => request.City).NotEmpty().WithMessage("City is required.").MaximumLength(50).WithMessage("City must not exceed 50 characters.");
            RuleFor(request => request.AddressLine).NotEmpty().WithMessage("Address line is required.").MaximumLength(250).WithMessage("Address line must not exceed 250 characters.");
            RuleFor(request => request.ZipCode).MaximumLength(6).WithMessage("Zip code must not exceed 6 characters.");
            RuleFor(request => request.IsDefault).NotNull().WithMessage("IsDefault must be specified.");
        }
    }
}
