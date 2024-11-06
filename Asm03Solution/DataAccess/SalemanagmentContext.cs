using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SalemanagmentContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public SalemanagmentContext() : base() 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Members
            modelBuilder.Entity<Member>().HasData(
                new Member { Id = 1, Email = "john.doe@example.com", CompanyName = "Tech Solutions", City = "New York", Country = "USA", Password = "securepassword123" },
                new Member { Id = 2, Email = "jane.smith@example.com", CompanyName = "Creative Co.", City = "San Francisco", Country = "USA", Password = "anotherpassword456" }
            );

            // Seed Orders
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, OrderDate = DateTime.Now.AddDays(-10), RequiredDate = DateTime.Now.AddDays(-5), ShipDate = DateTime.Now.AddDays(-3), Freight = 10000, MemberId = 1 },
                new Order { OrderId = 2, OrderDate = DateTime.Now.AddDays(-8), RequiredDate = DateTime.Now.AddDays(-4), ShipDate = DateTime.Now.AddDays(-2), Freight = 20000, MemberId = 2 }
            );

            // Seed OrderDetails
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { OrderDetailId = 1, UnitPrice = 150, Quantity = 2, Discount = 0.1f },
                new OrderDetail { OrderDetailId = 2, UnitPrice = 200, Quantity = 1, Discount = 0.05f }
            );

            // Seed Products
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Laptop", CategoryId = 1, Weight = "2.5kg", UnitPrice = 1000, UnitsInStock = 50, OrderDetailId = 1 },
                new Product { ProductId = 2, ProductName = "Mouse", CategoryId = 2, Weight = "0.1kg", UnitPrice = 20, UnitsInStock = 150, OrderDetailId = 1 },
                new Product { ProductId = 3, ProductName = "Keyboard", CategoryId = 2, Weight = "0.5kg", UnitPrice = 40, UnitsInStock = 100, OrderDetailId = 2 },
                new Product { ProductId = 4, ProductName = "Monitor", CategoryId = 3, Weight = "5kg", UnitPrice = 200, UnitsInStock = 30, OrderDetailId = 2 }
            );
        }

        private String ConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            if (configuration.GetConnectionString("DefaultConnectionString") == null)
            {
                throw new Exception("Connection string not found in appsettings.json");
            }
            return configuration.GetConnectionString("DefaultConnectionString");
        }
    }
}
