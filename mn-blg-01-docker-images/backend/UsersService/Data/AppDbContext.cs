using Microsoft.EntityFrameworkCore;
using UsersService.Models;

namespace UsersService.Data
{
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
                    Id = Guid.NewGuid(),
                    Name = "John Doe",
                    Email = "jn-email@somemail.com",
                    Password = "123456"
                });

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Mary Jane",
                    Email = "mj-email@someemail.com",
                    Password = "mremail23"
                });
        }
    }
}