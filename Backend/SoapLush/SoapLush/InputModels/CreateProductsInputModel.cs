namespace SoapLush.InputModels
{
    public class CreateProductsInputModel
    {
        public string Name { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Ingredients { get; set; } = string.Empty;

        public int Price { get; set; }

        public int CategoryId { get; set; }

        public int subCategortyId { get; set; }
    }
}
