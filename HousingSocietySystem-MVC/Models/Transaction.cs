namespace HousingSocietySystem_MVC.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Amount { get; set; }
        public Flat Flat { get; set; }
        public Maintenance Maintenance { get; set; }
    }
}
