namespace SoapLush.InputModels
{
    public class UpdeteProductsInputModel
    {
        public int ProductId { get; set; }

        public string Image { get; set; } = string.Empty;

        public string Price { get; set; } = string.Empty;

        public string CategoryId { get; set; } = string.Empty;

        public string subCategortyId { get; set; } = string.Empty;

    }
}
