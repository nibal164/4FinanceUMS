using FluentValidation;
using SoapLush.InputModels;

namespace SoapLush.Validators
{
    public class CreateSoapSubCategoryRequestValidator : AbstractValidator<CreateSoapSubCategoryInputModel>
    {
        CreateSoapSubCategoryRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}