using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.Book
{
    public class BookCreateDto
    {
        [Required]
        [StringLength(50)]
        public string? Title { get; set; }

        [Required]
        [Range(1800, 2200)]
        public int Year { get; set; }

        [Required]
        public string Isbn { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 10)]
        public string? Summary { get; set; }

        public string Image { get; set; }

        [Required]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        public decimal Price { get; set; }

        [Required]
        public int AuthorId { get; set; }
    }
}
