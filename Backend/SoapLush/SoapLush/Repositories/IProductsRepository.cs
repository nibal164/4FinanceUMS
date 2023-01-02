using SoapLush.Models;

namespace SoapLush.Repositories
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Products>> GetAllProductsAsync();
    }
}
