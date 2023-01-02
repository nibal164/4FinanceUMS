namespace SoapLush.InputModels
{
    public class UpdateSoapCategoryInputModel
    {
        public int SoapCategoryId { get; set; }

        public string Image { get; set; } = string.Empty;

        public string subCategortyId { get; set; } = string.Empty;
    }

}
