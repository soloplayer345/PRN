using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    internal class Cart : Food
    {
        public int Quantity { get; set; }
        public Cart(Food food, int quantity)
        {
            Id = food.Id;
            Name = food.Name;
            Price = food.Price;
            Quantity = quantity;
        }

        public Cart()
        {
        }
    }
}
