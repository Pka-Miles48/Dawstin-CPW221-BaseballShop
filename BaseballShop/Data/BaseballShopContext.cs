using Microsoft.EntityFrameworkCore;

public class BaseballShopContext : DbContext
{
    public BaseballShopContext(DbContextOptions<BaseballShopContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Category> Categories { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("YourConnectionString",
                sqlServerOptions => sqlServerOptions.EnableRetryOnFailure());
        }
    }
}
