using Lab2.Model;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Controller
{
    internal class CustomerController
    {
        ArrayList cartList = new ArrayList();
        public void viewTheMenu()
        {          
            FoodContext FoodContext = new FoodContext();
            if (FoodContext.Foods.Count() == 0)
            {
                Console.WriteLine("No food in the list");
            }
            else
            {
                foreach (Food food in FoodContext.Foods)
                {
                    Console.WriteLine($"{food.Id} {food.Name}, Price: {food.Price} VND");
                }
            }
        }
        public void orderFood()
        {
            Console.WriteLine("Enter food ID to order: ");
            int id = int.Parse(Console.ReadLine());
            FoodContext FoodContext = new FoodContext();
            Food food = FoodContext.Foods.FirstOrDefault(f => f.Id == id);
            if (food == null)
            {
                Console.WriteLine("Food not found");
            }
            else
            {
                Console.WriteLine("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                //cartList.Add(cart);
            }
        }
    }
}
