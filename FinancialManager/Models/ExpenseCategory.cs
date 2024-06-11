namespace FinancialManager.Models
{
    public class ExpenseCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal LimitPercentage { get; set; }
        public decimal CurrentSpending { get; set; }
    }
}
