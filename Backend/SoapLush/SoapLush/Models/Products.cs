namespace SoapLush.Models
{
    public class Products
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Ingredients { get; set; } = string.Empty;

        public string Price { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string subCategorty { get; set; } = string.Empty;

        public IEnumerable<SoapCategory> SoapCategories { get; set; }

        public IEnumerable<SoapSubCategory> SoapSubCategories { get; set;}
    }
}
