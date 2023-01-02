using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            return Ok(products);
        }
    }
}
