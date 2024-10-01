using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    internal class FoodContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }

        public FoodContext(): base()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().HasData(
                new Food
                {
                    Id = 1,
                    Name = "Bac Siu",
                    Price = 29000
                },
                new Food
                {
                    Id = 2,
                    Name = "Ca Phe Den",
                    Price = 25000
                },
                new Food
                {
                    Id = 3,
                    Name = "Tra Sua",
                    Price = 30000
                }
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local);Database=FoodDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
