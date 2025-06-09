using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Dawstin_CPW221_BaseballShop.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Dawstin_CPW221_BaseballShop.Baseball_Data
{
    /// <summary>
    /// Database context for BaseballShop, integrating Identity for authentication and managing data entities.
    /// </summary>
    public class BaseballShop : IdentityDbContext<ApplicationUser> // Enables ASP.NET Identity
    {
        /// <summary>
        /// Initializes a new instance of the BaseballShop database context.
        /// </summary>
        /// <param name="options">The options for configuring the database context.</param>
        public BaseballShop(DbContextOptions<BaseballShop> options) : base(options) { }

        /// <summary>
        /// Gets or sets the database table for store items.
        /// </summary>
        public DbSet<Item> Items { get; set; }

        /// <summary>
        /// Gets or sets the database table for product categories.
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets the database table for store events.
        /// </summary>
        public DbSet<Event> Events { get; set; }

        /// <summary>
        /// Gets or sets the database table for products available in the shop.
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the database table for customers.
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets the database table for customer orders.
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Gets or sets the database table for detailed order items.
        /// </summary>
        public DbSet<OrderDetail> OrderDetails { get; set; }

        /// <summary>
        /// Gets or internally sets the shopping cart instance.
        /// </summary>
        public object ShoppingCart { get; internal set; }

        /// <summary>
        /// Gets or internally sets the cart item instance.
        /// </summary>
        public object CartItem { get; internal set; }

        /// <summary>
        /// Configures entity relationships and seed data for the BaseballShop database.
        /// </summary>
        /// <param name="modelBuilder">The model builder used to define the entity relationships.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Call base method for Identity integration
            base.OnModelCreating(modelBuilder);

            // Configure relationships
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

            // Ignore Category property in Item entity
            modelBuilder.Entity<Item>().Ignore(i => i.Category);

            // Seed categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Bats" },
                new Category { CategoryID = 2, Name = "Gloves" }
            );

            // Seed products
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, Name = "Baseball Bat", Description = "High-quality aluminum bat", Price = 99.99m, Stock = 50, CategoryID = 1 },
                new Product { ProductID = 2, Name = "Baseball Glove", Description = "Durable leather glove", Price = 49.99m, Stock = 30, CategoryID = 2 }
            );
        }
    }
}
