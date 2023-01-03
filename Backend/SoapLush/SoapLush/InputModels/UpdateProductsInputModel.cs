namespace SoapLush.InputModels
{
    public class UpdateProductsInputModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Ingredients { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int Price { get; set; }

    }
}
