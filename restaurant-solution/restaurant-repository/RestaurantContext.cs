using Microsoft.EntityFrameworkCore;
using restaurant_domain;
using restaurant_repository.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace restaurant_repository
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
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
        }
    }
}
