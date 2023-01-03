using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoapLush.InputModels;
using SoapLush.Models;
using SoapLush.Repositories;

namespace SoapLush.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository productsRepository;

        public ProductsController(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }



        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await productsRepository.GetAllProductsAsync();
            var productsDto = new List<Dtos.ProductsDto>();
            products.ToList().ForEach(product =>
            {
                var productDto = new Dtos.ProductsDto()
                {
                    id = product.id,
                    Image = product.Image,
                    Name = product.Name,
                    Description = product.Description,
                    Ingredients = product.Ingredients,
                    Price = product.Price,
                    CategoryId = product.CategoryId,
                    subCategortyId = product.subCategortyId,
                };
                productsDto.Add(productDto);
            });
            return Ok(productsDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductsInputModel createProductsInputModel)
        {
            var product = new Models.Products()
            {
                Name = createProductsInputModel.Name,
                Description = createProductsInputModel.Description,
                Ingredients = createProductsInputModel.Ingredients,
                Price = createProductsInputModel.Price,
                Image = createProductsInputModel.Image,
                CategoryId = createProductsInputModel.CategoryId,
                subCategortyId = createProductsInputModel.subCategortyId,
            };

            product = await productsRepository.CreateProductAsync(product);
            var productDto = new Dtos.ProductsDto()
            {
                id = product.id,
                Name = product.Name,
                Description = product.Description,
                Ingredients = product.Ingredients,
                Price = product.Price,
                Image = product.Image,
                CategoryId = product.CategoryId,
                subCategortyId = product.subCategortyId,
            };
            return Ok(productDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await productsRepository.DeleteProductAsync(id);

            if(product == null)
            {
                return NotFound();
            }

            var productDto = new Dtos.ProductsDto()
            {
                id = product.id,
                Name = product.Name,
                Description = product.Description,
                Ingredients = product.Ingredients,
                Price = product.Price,
                Image = product.Image,
                CategoryId = product.CategoryId,
                subCategortyId = product.subCategortyId,
            };
            return Ok(productDto);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateProduct([FromRoute] int id, [FromBody] UpdateProductsInputModel updateProductsInputModel)
        {
            var product = new Models.Products()
            {
                Name = updateProductsInputModel.Name,
                Description = updateProductsInputModel.Description,
                Ingredients = updateProductsInputModel.Ingredients,
                Price = updateProductsInputModel.Price,
                Image = updateProductsInputModel.Image,

            };

            product = await productsRepository.UpdateProductAsync(id, product);

            if(product == null)
            {
                return NotFound();
            }

            var productDto = new Dtos.ProductsDto()
            {
                id = product.id,
                Name = product.Name,
                Description = product.Description,
                Ingredients = product.Ingredients,
                Price = product.Price,
                Image = product.Image,
                CategoryId = product.CategoryId,
                subCategortyId = product.subCategortyId,
            };
            return Ok(productDto);
        }
    }
}

