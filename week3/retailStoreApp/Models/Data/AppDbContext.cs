using Microsoft.EntityFrameworkCore;
using RetailStoreApp.Models;

namespace RetailStoreApp.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        optionsBuilder.UseSqlServer("Server=localhost;Database=RetailInventoryDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
