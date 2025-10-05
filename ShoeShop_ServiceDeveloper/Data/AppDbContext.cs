using Microsoft.EntityFrameworkCore;
using ShoeShop.Models;

namespace ShoeShop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Shoe>().HasData(
                new Shoe { Id = 1, Name = "Air Zoom Pegasus", Brand = "Nike", Price = 4999, Stock = 20 },
                new Shoe { Id = 2, Name = "Ultraboost 22", Brand = "Adidas", Price = 5999, Stock = 15 }
            );

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 1, Name = "Global Shoe Supplies", ContactNumber = "09123456789", Email = "supplier@example.com" }
            );
        }
    }
}