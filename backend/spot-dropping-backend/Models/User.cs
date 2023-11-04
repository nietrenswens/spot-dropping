using System.ComponentModel.DataAnnotations;

namespace spotdropping.Models
{
    public class User
    {
        [Key]
        [Required, MaxLength(22)]
        public string Email { get; set; } = null!;
        [Required, MaxLength(22)]
        public string Name { get; set; } = null!;
        [Required, MaxLength(100)]
        public string Password { get; set; } = null!;
        public int usertypeid { get; set; }
        public UserType UserType { get; set; } = null!;
        public Game? OwnedGame { get; set; }
    }
}
