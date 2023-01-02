using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoapLush.Repositories;

namespace SoapLush.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoapCategoryController : ControllerBase
    {
        private readonly ISoapCategoryRepository soapCategoryRepository;
        public SoapCategoryController(ISoapCategoryRepository soapCategoryRepository)
        {
            this.soapCategoryRepository = soapCategoryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await soapCategoryRepository.GetAllSoapCategoryAsync();
            return Ok(categories);
        }
    }
}
