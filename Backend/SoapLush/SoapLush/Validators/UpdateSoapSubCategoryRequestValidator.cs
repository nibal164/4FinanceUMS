using FluentValidation;
using SoapLush.InputModels;

namespace SoapLush.Validators
{
    public class UpdateSoapSubCategoryRequestValidator : AbstractValidator<UpdateSoapSubCategoryInputModel>
    {
        public UpdateSoapSubCategoryRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}