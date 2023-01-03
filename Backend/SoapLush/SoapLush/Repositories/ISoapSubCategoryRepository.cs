using SoapLush.Models;

namespace SoapLush.Repositories
{
    public interface ISoapSubCategoryRepository
    {
        Task<IEnumerable<SoapSubCategory>> GetAllSoapSubCategoryAsync();

        Task<SoapSubCategory> CreateSoapSubCategoryAsync(SoapSubCategory subCategory);

        Task<SoapSubCategory> DeleteSoapSubCategoryAsync(int id);

        Task<SoapSubCategory> UpdateSoapSubCategoryAsync(int id, SoapSubCategory soapSubCategory);
    }
}
