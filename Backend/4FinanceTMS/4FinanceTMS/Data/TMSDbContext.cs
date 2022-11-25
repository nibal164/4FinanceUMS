using _4FinanceTMS.Models;
using Microsoft.EntityFrameworkCore;

namespace _4FinanceTMS.Data
{
    public class TMSDbContext : DbContext
    {
        public TMSDbContext(DbContextOptions<TMSDbContext> options) : base(options)
        {

        }
    
        //if table does not exist it creates it
        public DbSet<Teachers> Teacher { get; set; }
        public DbSet<Students> Student { get; set; }
        public DbSet<Cources> Cource{ get; set; }  

    }

    
}
