using FluentValidation;
using SoapLush.InputModels;

namespace SoapLush.Validators
{
    public class UpdateProductsRequestValidator: AbstractValidator<UpdeteProductsInputModel>
    {
        public UpdateProductsRequestValidator()
        {
            RuleFor(x => x.Image).NotEmpty();
            RuleFor(x => x.Price).NotEmpty();
            RuleFor(x => x.CategoryId).NotEmpty();
            RuleFor(x => x.subCategortyId).NotEmpty();
        }
    }
}
