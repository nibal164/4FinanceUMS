using Microsoft.EntityFrameworkCore;
using SoapLush.Data;
using SoapLush.Models;

namespace SoapLush.Repositories
{
    public class SoapSubCategoryRepository: ISoapSubCategoryRepository
    {
        private readonly SoapLushDbContext _SOAPLUSHDBCONTEXT;

        public SoapSubCategoryRepository(SoapLushDbContext SOAPLUSHDBCONTEXT)
        {
            this._SOAPLUSHDBCONTEXT = SOAPLUSHDBCONTEXT;
        }

        public async Task<IEnumerable<SoapSubCategory>> GetAllSoapSubCategoryAsync()
        {
            return await _SOAPLUSHDBCONTEXT.SoapSubCategories.ToListAsync();
        }

        public async Task<SoapSubCategory> CreateSoapSubCategoryAsync(SoapSubCategory subCategory)
        {
            await _SOAPLUSHDBCONTEXT.SoapSubCategories.AddAsync(subCategory);
            await _SOAPLUSHDBCONTEXT.SaveChangesAsync();
            return subCategory; 
        }

        public async Task<SoapSubCategory> DeleteSoapSubCategoryAsync(int id)
        {
            var soapSubCategory = await _SOAPLUSHDBCONTEXT.SoapSubCategories.FirstOrDefaultAsync(x => x.id == id);
            if (soapSubCategory == null)
            {
                return null;
            }
            _SOAPLUSHDBCONTEXT.Remove(soapSubCategory);
            await _SOAPLUSHDBCONTEXT.SaveChangesAsync();
            return soapSubCategory;
        }

        public async Task<SoapSubCategory> UpdateSoapSubCategoryAsync(int id, SoapSubCategory soapSubCategory)
        {
            var existingSoapSubCategory = await _SOAPLUSHDBCONTEXT.SoapSubCategories.FirstOrDefaultAsync(x => x.id == id);
            if (existingSoapSubCategory == null)
            {
                return null;
            }
            existingSoapSubCategory.id = soapSubCategory.id;
            existingSoapSubCategory.Name = soapSubCategory.Name;

            await _SOAPLUSHDBCONTEXT.SaveChangesAsync();
            return existingSoapSubCategory;
        }
    }
}
