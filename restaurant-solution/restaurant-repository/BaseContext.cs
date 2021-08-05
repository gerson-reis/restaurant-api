using Microsoft.EntityFrameworkCore;
using Restaurant.Domain;
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
        public DbSet<Client> Clients { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PlateConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClientConfiguration).Assembly);
        }
    }
}
