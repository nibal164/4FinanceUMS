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
    }
}
