using FluentValidation;
using SoapLush.InputModels;

namespace SoapLush.Validators
{
    public class UpdateProductsRequestValidator: AbstractValidator<UpdateProductsInputModel>
    {
        public UpdateProductsRequestValidator()
        {
            RuleFor(x => x.Image).NotEmpty();
            RuleFor(x => x.Price).NotNull();
        }
    }
}
