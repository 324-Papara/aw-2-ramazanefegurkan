using Para.Data.Domain;
using FluentValidation;
using Para.Schema;

namespace Para.Bussiness.Validation
{
    public class CustomerRequestValidator : AbstractValidator<CustomerRequest>
    {
        public CustomerRequestValidator()
        {
            RuleFor(customer => customer.FirstName)
                .NotEmpty().WithMessage("First name is required.")
                .MaximumLength(50).WithMessage("First name must not exceed 50 characters.");

            RuleFor(customer => customer.LastName)
                .NotEmpty().WithMessage("Last name is required.")
                .MaximumLength(50).WithMessage("Last name must not exceed 50 characters.");

            RuleFor(customer => customer.IdentityNumber)
                .NotEmpty().WithMessage("Identity number is required.")
                .Length(11).WithMessage("Identity number must be 11 characters.");

            RuleFor(customer => customer.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email address.");

            RuleFor(customer => customer.DateOfBirth)
                .NotEmpty().WithMessage("Date of birth is required.");
        }
    }
}
