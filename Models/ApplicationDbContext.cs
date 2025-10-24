using Microsoft.EntityFrameworkCore;
namespace MyFirstApp.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Movie> movies { get; set; }
    public DbSet<Customer> customers { get; set; }
    public DbSet<Gender> genres{ get; set; }
}