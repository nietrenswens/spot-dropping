using System.ComponentModel.DataAnnotations;

namespace spotdropping.Models
{
    public class Game
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int LocationRound { get; set; } = 0;
        [Required]
        public GameState State { get; set; } = GameState.WAITING;
        [Required]
        public string HiderInviteCode { get; set; } = null!;
        [Required]
        public string SeekerInviteCode { get; set; } = null!;
        [Required]
        public string owneremail { get; set; } = null!;
        public User Owner { get; set; } = null!;
        public List<User> Hiders { get; set; } = null!;
        public List<User> Seekers { get; set; } = null!;
    }
    public enum GameState
    {
        WAITING, STARTING, ENDING, ENDED
    }
}
