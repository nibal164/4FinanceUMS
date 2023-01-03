using Microsoft.EntityFrameworkCore;
using SoapLush.Data;
using SoapLush.Models;

namespace SoapLush.Repositories
{
    public class SoapCategoryRepository: ISoapCategoryRepository
    {
        private readonly SoapLushDbContext _SOAPLUSHDBCONTEXT;

        public SoapCategoryRepository(SoapLushDbContext SOAPLUSHDBCONTEXT)
        {
            this._SOAPLUSHDBCONTEXT = SOAPLUSHDBCONTEXT;
        }

        public async Task<IEnumerable<SoapCategory>> GetAllSoapCategoryAsync()
        {
            return await _SOAPLUSHDBCONTEXT.SoapCategories.ToListAsync();
        }

        public async Task<SoapCategory> CreateSoapCategoryAsync(SoapCategory category)
        {
            await _SOAPLUSHDBCONTEXT.SoapCategories.AddAsync(category);
            await _SOAPLUSHDBCONTEXT.SaveChangesAsync();
            return category;
        }

        public async Task<SoapCategory> DeleteSoapCategoryAsync(int id)
        {
            var soapCategory = await _SOAPLUSHDBCONTEXT.SoapCategories.FirstOrDefaultAsync(x => x.id == id);
            if (soapCategory == null)
            {
                return null;
            }
            _SOAPLUSHDBCONTEXT.Remove(soapCategory);
            await _SOAPLUSHDBCONTEXT.SaveChangesAsync();
            return soapCategory;
        }

        public async Task<SoapCategory> UpdateSoapCategoryAsync(int id, SoapCategory soapCategory)
        {
            var existingSoapCategory = await _SOAPLUSHDBCONTEXT.SoapCategories.FirstOrDefaultAsync(x => x.id == id);
            if (existingSoapCategory == null)
            {
                return null;
            }
            existingSoapCategory.id = soapCategory.id;
            existingSoapCategory.Name = soapCategory.Name;
            existingSoapCategory.Image = soapCategory.Image;
            existingSoapCategory.subCategortyId = soapCategory.subCategortyId;

            await _SOAPLUSHDBCONTEXT.SaveChangesAsync();
            return existingSoapCategory;
        }
    }
}

