namespace FinancialManager.Models
{
    public class Debt
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Debtor { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsReturned { get; set; }

    }
}
