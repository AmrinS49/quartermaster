using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Bearing> Bearings { get; set; }

        public DbSet<CustomItem> CustomItems { get; set; }
    }
}