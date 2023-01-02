using Microsoft.EntityFrameworkCore;
using SoapLush.Data;
using SoapLush.Models;

namespace SoapLush.Repositories
{
    public class ProductRepository : IProductsRepository
    {
        private readonly SoapLushDbContext _SOAPLUSHDBCONTEXT;
        
        public ProductRepository(SoapLushDbContext SOAPLUSHDBCONTEXT)
        {
            this._SOAPLUSHDBCONTEXT = SOAPLUSHDBCONTEXT;
        }

        public async Task<IEnumerable<Products>> GetAllProductsAsync()
        {
            return await _SOAPLUSHDBCONTEXT.Products.ToListAsync();
        }
    }
}
