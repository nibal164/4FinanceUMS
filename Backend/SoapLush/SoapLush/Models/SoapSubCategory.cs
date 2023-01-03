namespace SoapLush.Models
{
    public class SoapSubCategory
    {
        public int id { get; set; }

        public string Name { get; set; } = string.Empty;

        public IEnumerable<SoapCategory> SoapCategories { get; set; }
    }
}
