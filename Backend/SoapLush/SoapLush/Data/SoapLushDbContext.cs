using Microsoft.EntityFrameworkCore;
using SoapLush.Models;

namespace SoapLush.Data
{
    public class SoapLushDbContext: DbContext
    {
        public SoapLushDbContext(DbContextOptions<SoapLushDbContext> options) : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }

        public DbSet<SoapCategory> SoapCategories { get; set; }

        public DbSet<SoapSubCategory> SoapSubCategories { get; set;}

    }
}
