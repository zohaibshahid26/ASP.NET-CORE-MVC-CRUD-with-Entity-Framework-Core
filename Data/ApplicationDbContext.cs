using Microsoft.EntityFrameworkCore;
using Lab3.Models;

namespace Lab3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 4); // Sets the precision to 18 and the scale to 4

            modelBuilder.Entity<Subscription>()
                .Property(s => s.Price)
                .HasPrecision(18, 4);


        }
    }
}
