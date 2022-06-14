using Microsoft.EntityFrameworkCore;

namespace TrainingSolution.MinimalApi;

public class OrderDbContext : DbContext
{
    public OrderDbContext(DbContextOptions options): base(options) { }

    public DbSet<Order> Orders => Set<Order>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>().HasData(
            new Order
            {
                Id= 1,
                Description = "New equipment for construction",
                PromoCode = "NEW_EQUIPMENT",
                Created = DateTime.Now,
                OrderNumber = 100,
                Total = 175
            },
            new Order
            {
                Id=2,
                Description = "Construction truck",
                PromoCode = "NEW_TRUCK",
                Created = DateTime.Now,
                OrderNumber = 101,
                Total = 1075
            }
        );
    }
}