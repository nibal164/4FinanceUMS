using FluentValidation;
using SoapLush.InputModels;

namespace SoapLush.Validators
{
    public class CreateProductsRequestValidator: AbstractValidator<CreateProductsInputModel>
    {
        CreateProductsRequestValidator() 
        {
            RuleFor(x=> x.Name).NotEmpty();
            RuleFor(x=> x.Image).NotEmpty();
            RuleFor(x=> x.Description).NotEmpty();
            RuleFor(x=> x.Ingredients).NotEmpty();
            RuleFor(x=> x.Price).NotEmpty();
            RuleFor(x=> x.CategoryId).NotEmpty();
            RuleFor(x=> x.subCategortyId).NotEmpty();

        }
    }
}
