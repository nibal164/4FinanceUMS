namespace SoapLush.Models
{
    public class Products
    {
        public int id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Ingredients { get; set; } = string.Empty;

        public string Price { get; set; } = string.Empty;

        public string CategoryId { get; set; } = string.Empty;

        public string subCategortyId { get; set; } = string.Empty;

    }
}
