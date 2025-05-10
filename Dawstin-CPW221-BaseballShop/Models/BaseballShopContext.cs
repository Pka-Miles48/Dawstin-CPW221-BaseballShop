using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dawstin_CPW221_BaseballShop.Models
{
    public class BaseballShopContext : IdentityDbContext<ApplicationUser>
    {
        public BaseballShopContext(DbContextOptions<BaseballShopContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

    public class ApplicationUser : IdentityUser
    {
        // Add custom fields if needed
    }
}
