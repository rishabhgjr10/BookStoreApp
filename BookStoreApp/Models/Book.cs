using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.Models
{
    public class Book
    {
        [Key]  // Primary key
        public int Id { get; set; }

        [Required]  // Not null
        [StringLength(50)]  // max 50 characters
        public string BookName { get; set; }

        [Required]
        [StringLength(35)]
        public string Genre { get; set; }

        public bool AvailabilityStatus { get; set; }
    }
}
