using Microsoft.EntityFrameworkCore;
using bProject_ASPNET.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                ID = 3,
                Name = "First User",
                UserHobby = Hobby.Basketball,
                Email = "firstuser@gmail.com"
            }
        );
    }
}