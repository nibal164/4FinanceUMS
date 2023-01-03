using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoapLush.Models;
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

        [HttpPost]
        public async Task<IActionResult> CreateSoapCategory(SoapCategory category)
        {
            var SoapCategory = await soapCategoryRepository.CreateSoapCategoryAsync(category);
            return Ok(SoapCategory);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteSoapCategoryAsync(int id)
        {
            var soapCategory = await soapCategoryRepository.DeleteSoapCategoryAsync(id);

            if (soapCategory == null)
            {
                return NotFound();
            }
            return Ok(soapCategory);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateSoapCategoryAsync([FromRoute] int id, [FromBody] SoapCategory soapCategory)
        {
            soapCategory = await soapCategoryRepository.UpdateSoapCategoryAsync(id, soapCategory);

            if (soapCategory == null)
            {
                return NotFound();
            }
            return Ok(soapCategory);
        }
    }
}
