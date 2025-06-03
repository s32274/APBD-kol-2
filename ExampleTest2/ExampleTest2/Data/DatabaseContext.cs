using ExampleTest2.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleTest2.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Status> Status { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductOrder> ProductOrders { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Client>().HasData(new List<Client>
            {
                new Client { Id = 1, FirstName = "John", LastName = "Doe" }
            });

            modelBuilder.Entity<Status>().HasData(new List<Status>
            {
                new Status { Id = 1, Name = "Ongoing" },
                new Status { Id = 2, Name = "Complete" }
            });

            modelBuilder.Entity<Product>().HasData(new List<Product>
            {
                new Product { Id = 1, Name = "Bananas", Price = 5.55m },
                new Product { Id = 2, Name = "Orange", Price = 12.37m },
            });

            modelBuilder.Entity<Order>().HasData(new List<Order>
            {
                new Order { Id = 1, CreatedAt = DateTime.Parse("2024-05-28"), FulfilledAt = null, ClientId = 1, StatusId = 1 }
            });

            modelBuilder.Entity<ProductOrder>().HasData(new List<ProductOrder>
            {
                new ProductOrder { ProductId = 1, OrderId = 1, Amount = 2 },
                new ProductOrder { ProductId = 2, OrderId = 1, Amount = 1 }
            });
    }
}
