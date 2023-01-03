using SoapLush.Models;

namespace SoapLush.Repositories
{
    public interface ISoapCategoryRepository
    {
        Task<IEnumerable<SoapCategory>> GetAllSoapCategoryAsync();

        Task<SoapCategory> CreateSoapCategoryAsync(SoapCategory category);

        Task<SoapCategory> DeleteSoapCategoryAsync(int id);

        Task<SoapCategory> UpdateSoapCategoryAsync(int id, SoapCategory soapCategory);
    }
}
