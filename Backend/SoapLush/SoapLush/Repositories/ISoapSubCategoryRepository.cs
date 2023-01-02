using SoapLush.Models;

namespace SoapLush.Repositories
{
    public interface ISoapSubCategoryRepository
    {
        Task<IEnumerable<SoapSubCategory>> GetAllSoapSubCategoryAsync();
    }
}
