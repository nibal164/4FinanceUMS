namespace SoapLush.InputModels
{
    public class CreateSoapCategoryInputModel
    {
        public int SoapCategoryId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public string subCategortyId { get; set; } = string.Empty;
    }
}
