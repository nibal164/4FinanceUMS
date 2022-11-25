namespace _4FinanceTMS.Models
{
    public class Teachers
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Specality { get; set; } = string.Empty;

        //Navigation Properties
        public IEnumerable<Cources> Cource { get; set; }
    }
}
