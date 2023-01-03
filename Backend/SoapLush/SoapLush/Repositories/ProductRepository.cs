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

        public async Task<Products> CreateProductAsync(Products product)
        {
        product.id = new int();
        await _SOAPLUSHDBCONTEXT.Products.AddAsync(product);
        await _SOAPLUSHDBCONTEXT.SaveChangesAsync();
        return product;
        }

        public async Task<Products> DeleteProductAsync(int id)
        {
            var product = await _SOAPLUSHDBCONTEXT.Products.FirstOrDefaultAsync(x => x.id == id);
            if(product == null)
            {
                return null;
            }
            _SOAPLUSHDBCONTEXT.Remove(product);
            await _SOAPLUSHDBCONTEXT.SaveChangesAsync();
            return product;
        }

        public async Task<Products> UpdateProductAsync(int id, Products product)
        {
            var existingProduct = await _SOAPLUSHDBCONTEXT.Products.FirstOrDefaultAsync(x => x.id == id);
            if(existingProduct == null)
            {
                return null;
            }
            existingProduct.id = product.id;
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Description = product.Description;
            existingProduct.Ingredients = product.Ingredients;
            existingProduct.CategoryId= product.CategoryId;
            existingProduct.subCategortyId = product.subCategortyId;

            await _SOAPLUSHDBCONTEXT.SaveChangesAsync();
            return existingProduct;
        }
    }
}
