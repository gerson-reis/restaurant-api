using Microsoft.EntityFrameworkCore;
using Restaurant.Repository.Configuration;
using restaurant_domain;

namespace Restaurant.Repository
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {
        }

        public DbSet<Plate> Plates { get; set; }
        //public DbSet<Store> Stores { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<Cart> Carts { get; set; }
        //public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PlateConfiguration).Assembly);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(StoreConfiguration).Assembly);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(OrderConfiguration).Assembly);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(CartConfiguration).Assembly);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(CartItemConfiguration).Assembly);
        }
    }
}
