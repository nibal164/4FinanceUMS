using _4FinanceTMS.Data;
using _4FinanceTMS.Models;
using Microsoft.EntityFrameworkCore;

namespace _4FinanceTMS.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly TMSDbContext _TMSDbContext;

        //constuctor that inject the _TMSDbContext in the class
        public TeacherRepository(TMSDbContext tmsDbContext)
        {
            this._TMSDbContext = tmsDbContext;
        }

        public async Task<IEnumerable<Teachers>> GetAllAsync()
        {
            return await _TMSDbContext.Teacher.ToListAsync();
        }

        public async Task<Teachers> GetAsync(Guid id)
        {
            return await _TMSDbContext.Teacher.FirstOrDefaultAsync(t => t.Id == id);
        }


        public async Task<Teachers> CreateTeacherAsync(Teachers teachers)
        {
            teachers.Id = new Guid();
            await _TMSDbContext.Teacher.AddAsync(teachers);
            await _TMSDbContext.SaveChangesAsync();
            return teachers;
        }

        public async Task<Teachers> DeleteTeacherAsync(Guid id)
        {
            var teacher = await _TMSDbContext.Teacher.FirstOrDefaultAsync(x => x.Id == id);
            if(teacher == null)
            {
                return null;
            }

            _TMSDbContext.Teacher.Remove(teacher);
            await _TMSDbContext.SaveChangesAsync();
            return teacher;
        }

        public async Task<Teachers> UpdateTeacherAsync(Guid id, Teachers teachers)
        {
            var existingTeachers = await _TMSDbContext.Teacher.FirstOrDefaultAsync(x =>x.Id ==id);
            if(existingTeachers == null) { return null; }

            existingTeachers.Name = teachers.Name;
            existingTeachers.Email = existingTeachers.Email;
            existingTeachers.Specality = teachers.Specality;

            await _TMSDbContext.SaveChangesAsync();
            return existingTeachers;
        }
    }
}
