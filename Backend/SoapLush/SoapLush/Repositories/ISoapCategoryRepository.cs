using SoapLush.Models;

namespace SoapLush.Repositories
{
    public interface ISoapCategoryRepository
    {
        Task<IEnumerable<SoapCategory>> GetAllSoapCategoryAsync();
    }
}
