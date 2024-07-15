using Para.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Para.Bussiness.Validation
{
    public class CustomerDetailRequestValidator : AbstractValidator<CustomerDetailRequest>
    {
        public CustomerDetailRequestValidator()
        {

            RuleFor(x => x.FatherName).NotEmpty().WithMessage("Father's name is required.").MaximumLength(50);
            RuleFor(x => x.MotherName).NotEmpty().WithMessage("Mother's name is required.").MaximumLength(50);
            RuleFor(x => x.EducationStatus).NotEmpty().WithMessage("Education status is required.").MaximumLength(50);
            RuleFor(x => x.MontlyIncome).NotEmpty().WithMessage("Monthly income is required.").MaximumLength(50);
            RuleFor(x => x.Occupation).NotEmpty().WithMessage("Occupation is required.").MaximumLength(50);

        }
    }
}
