using System;
using Microsoft.EntityFrameworkCore;
using StockManagement.Entity.Concrete;

namespace StockManagement.DataAccess.Concrete.EntityFramework
{
    public class StockManagementContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ECommerceSite> ECommerceSites { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
