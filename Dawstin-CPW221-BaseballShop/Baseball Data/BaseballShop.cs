using Microsoft.EntityFrameworkCore;
using Dawstin_CPW221_BaseballShop.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Dawstin_CPW221_BaseballShop.Baseball_Data
{
    public class BaseballShop : DbContext
    {
        public BaseballShop(DbContextOptions<BaseballShop> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relationships from the second snippet
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany()
                .HasForeignKey(o => o.CustomerID);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany()
                .HasForeignKey(od => od.OrderID);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany()
                .HasForeignKey(od => od.ProductID);

            modelBuilder.Entity<Item>().Ignore(i => i.Category);

            base.OnModelCreating(modelBuilder);
        }
    }
}
