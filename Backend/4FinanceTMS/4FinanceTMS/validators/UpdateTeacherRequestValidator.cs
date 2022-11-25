using _4FinanceTMS.InputModels;
using FluentValidation;

namespace _4FinanceTMS.validators
{
    public class UpdateTeacherRequestValidator: AbstractValidator<UpdateTeacherInputModel>
    {
        public UpdateTeacherRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Specality).NotEmpty();
        }
    }
}
