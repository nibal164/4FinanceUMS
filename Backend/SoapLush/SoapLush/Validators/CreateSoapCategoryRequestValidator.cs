using FluentValidation;
using SoapLush.InputModels;

namespace SoapLush.Validators
{
    public class CreateSoapCategoryRequestValidator : AbstractValidator<CreateSoapCategoryInputModel>
    {
        CreateSoapCategoryRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Image).NotEmpty();
            RuleFor(x => x.subCategortyId).NotEmpty();
        }
    }
}
