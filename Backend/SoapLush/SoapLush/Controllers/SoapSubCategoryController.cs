using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoapLush.Models;
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

        [HttpPost]
        public async Task<IActionResult> CreateSoapSubCategory(SoapSubCategory subCategory)
        {
            var SoapSubCategory = await soapSubCategoryRepository.CreateSoapSubCategoryAsync(subCategory);
            return Ok(SoapSubCategory);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteSoapSubCategoryAsync(int id)
        {
            var soapSubCategory = await soapSubCategoryRepository.DeleteSoapSubCategoryAsync(id);

            if (soapSubCategory == null)
            {
                return NotFound();
            }
            return Ok(soapSubCategory);
        }

        [HttpPut("{id:int}")]

        public async Task<IActionResult> UpdateSoapSubCategoryAsync([FromRoute] int id, [FromBody] SoapSubCategory soapSubCategory)
        {
            soapSubCategory = await soapSubCategoryRepository.UpdateSoapSubCategoryAsync(id, soapSubCategory);

            if (soapSubCategory == null)
            {
                return NotFound();
            }
            return Ok(soapSubCategory);
        }
    }
}
