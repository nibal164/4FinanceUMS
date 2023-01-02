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
    }
}
