using System.ComponentModel.DataAnnotations;

namespace BookstoreProject.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        //public ICollection<Review> Reviews { get; set; }
    }
}
