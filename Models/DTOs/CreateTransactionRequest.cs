namespace FinTrack.Models.DTOs
{
    public class CreateTransactionRequest
    {
        public string Type { get; set; } = null!;
        public decimal Amount { get; set; }
        public string Description { get; set; } = null!;
    }
}
