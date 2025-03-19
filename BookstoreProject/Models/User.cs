using System.ComponentModel.DataAnnotations;

namespace BookstoreProject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
    }
}
