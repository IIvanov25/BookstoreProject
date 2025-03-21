using System.ComponentModel.DataAnnotations;

namespace BookstoreProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
