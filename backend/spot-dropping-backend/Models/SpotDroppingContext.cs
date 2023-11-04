using Microsoft.EntityFrameworkCore;

namespace spotdropping.Models
{
    public class SpotDroppingContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost:5432;Username=root;Password=root;Database=spotdroppingdb;Maximum Pool Size=200");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne<UserType>()
                .WithMany(_ => _.Users)
                .HasForeignKey(_ => _.usertypeid);
            modelBuilder.Entity<Game>()
                .HasOne(_ => _.Owner)
                .WithOne(_ => _.OwnedGame)
                .IsRequired(false);
        }

    }
}
