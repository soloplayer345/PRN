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
    }
}
