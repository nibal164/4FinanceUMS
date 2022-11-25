namespace _4FinanceTMS.Models
{
    public class Students
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Major { get; set; } = string.Empty;

        public IEnumerable<Cources> Cource { get; set; }
    }
}
