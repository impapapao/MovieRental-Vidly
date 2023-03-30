using System;
using System.ComponentModel.DataAnnotations;

namespace MovieRentalAPI.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public DateTime? DateRented { get; set; }
        public bool? IsAvailable { get; set; }

    }
}
