using SoapLush.Models;

namespace SoapLush.Repositories
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Products>> GetAllProductsAsync();

        Task<Products> CreateProductAsync (Products product);

        Task<Products> DeleteProductAsync (int id);

        Task<Products> UpdateProductAsync (int id, Products product);
    }
}
