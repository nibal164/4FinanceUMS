namespace SoapLush.Models
{
    public class SoapCategory
    {
        public int id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public int subCategortyId { get; set; }

        public IEnumerable<Products> Products { get; set; }

        public IEnumerable<SoapSubCategory> SoapSubCategories { get; set; }
    }
}
