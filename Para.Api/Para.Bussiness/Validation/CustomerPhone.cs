using FluentValidation;
using Para.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para.Bussiness.Validation
{
    public class CustomerPhoneValidator : AbstractValidator<CustomerPhoneRequest>
    {
        public CustomerPhoneValidator()
        {
            RuleFor(x => x.CountyCode).NotEmpty().WithMessage("County code is required.")
                .Length(3).WithMessage("County code must be exactly 3 characters long.");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone number is required.")
                .Length(10).WithMessage("Phone number must be exactly 10 characters long.");
        }
    }
}
