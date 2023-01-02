using FluentValidation;
using SoapLush.InputModels;

namespace SoapLush.Validators
{
    public class UpdateSoapCategoryRequestValidator : AbstractValidator<UpdateSoapCategoryInputModel>
    {
        public UpdateSoapCategoryRequestValidator()
        {
            RuleFor(x => x.Image).NotEmpty();
            RuleFor(x => x.subCategortyId).NotEmpty();
        }
    }
}