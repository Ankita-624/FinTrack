using System.ComponentModel.DataAnnotations;

namespace FinTrack.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        public string ? Type { get; set; }  // "Income" or "Expense"

        [Required]
        public decimal Amount { get; set; }

        public string ? Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string ? UserId { get; set; }
        public ApplicationUser? User { get; set; }
    }
}
