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
    }
}
