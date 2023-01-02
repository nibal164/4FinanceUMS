using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoapLush.Repositories;

namespace SoapLush.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoapSubCategoryController : ControllerBase
    {
        private readonly ISoapSubCategoryRepository soapSubCategoryRepository;
        public SoapSubCategoryController(ISoapSubCategoryRepository soapSubCategoryRepository)
        {
            this.soapSubCategoryRepository = soapSubCategoryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var subCategories = await soapSubCategoryRepository.GetAllSoapSubCategoryAsync();
            return Ok(subCategories);
        }
    }
}
