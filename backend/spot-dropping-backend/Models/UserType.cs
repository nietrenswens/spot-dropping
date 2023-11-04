using System.ComponentModel.DataAnnotations;

namespace spotdropping.Models
{
    public class UserType
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Type { get; set; } = null!;
        public List<User> Users { get; set; } = null!;
    }
}
