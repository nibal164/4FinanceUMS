using _4FinanceTMS.Models;

namespace _4FinanceTMS.Repositories
{
    public interface ITeacherRepository
    {
        Task<IEnumerable<Teachers>>GetAllAsync();

        Task<Teachers>GetAsync(Guid id);

        Task<Teachers>CreateTeacherAsync(Teachers teachers);

        Task <Teachers> DeleteTeacherAsync(Guid id);

        Task<Teachers> UpdateTeacherAsync(Guid id, Teachers teachers);
    }
}


