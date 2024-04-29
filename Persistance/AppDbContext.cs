using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.Persistance;
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=LAPTOP-SQHLN3F2;Database=MYtempdb;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}