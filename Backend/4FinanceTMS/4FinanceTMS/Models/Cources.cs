namespace _4FinanceTMS.Models
{
    public class Cources
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CreditNumber { get; set; }

        //Navigation Properties
        public IEnumerable<Teachers> Teacher { get; set; }
        public IEnumerable<Students> Student { get; set; }
    }
}
