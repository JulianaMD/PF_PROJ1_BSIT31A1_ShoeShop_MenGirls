using Microsoft.EntityFrameworkCore;
using ShoeShop_WebDesigner.Models; // ✅ Use the same namespace for all your models

namespace ShoeShop_WebDesigner.Data
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

            // --- Seed Shoes ---
            modelBuilder.Entity<Shoe>().HasData(
                new Shoe
                {
                    Id = 1,
                    Name = "Air Zoom Pegasus",
                    Brand = "Nike",
                    Price = 4999,
                    Stock = 20,
                    Color = "Black"
                },
                new Shoe
                {
                    Id = 2,
                    Name = "Ultraboost 22",
                    Brand = "Adidas",
                    Price = 5999,
                    Stock = 15,
                    Color = "White"
                }
            );

            // --- Seed Suppliers ---
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier
                {
                    Id = 1,
                    Name = "Global Shoe Supplies",
                    Contact = "09123456789",
                    Email = "supplier@example.com"
                }
            );

            // --- Seed PurchaseOrders ---
            modelBuilder.Entity<PurchaseOrder>().HasData(
                new PurchaseOrder
                {
                    Id = 1,
                    OrderDate = DateTime.Now.AddDays(-7),
                    Quantity = 50,
                    SupplierId = 1
                }
            );
        }
    }
}