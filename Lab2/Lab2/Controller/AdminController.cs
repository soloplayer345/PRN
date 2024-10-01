using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Controller
{
    internal class AdminController
    {
        public void viewAllFood()
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
                    Console.WriteLine($"ID: {food.Id}, Name: {food.Name}, Price: {food.Price}");
                }
            }
        }

        public void addFood()
        {
            Console.WriteLine("Enter food name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter food price: ");
            float price = float.Parse(Console.ReadLine());
            FoodContext FoodContext = new FoodContext();
            Food newFood = new Food { Name = name, Price = price };
            FoodContext.Foods.Add(newFood);
            FoodContext.SaveChanges();
            Console.WriteLine("Food added successfully");
        }
        public void removeFood()
        {
            Console.WriteLine("Enter food name to remove: ");
            String RemoveName = Console.ReadLine();
            FoodContext FoodContext = new FoodContext();
            Food food = FoodContext.Foods.FirstOrDefault(f => f.Name == RemoveName);
            if (food == null)
            {
                Console.WriteLine("Food not found");
            }
            else
            {
                FoodContext.Foods.Remove(food);
                FoodContext.SaveChanges();
                Console.WriteLine("Food removed successfully");
            }
        }
        public void updateFood()
        {
            Console.WriteLine("Enter food name to update: ");
            String UpdateName = Console.ReadLine();
            Console.WriteLine("Enter new price (leave blank to keep the old price): ");
            string newPriceInput = Console.ReadLine();
            float newPrice;
            if (string.IsNullOrEmpty(newPriceInput))
            {
                FoodContext FoodContext = new FoodContext();
                Food food = FoodContext.Foods.FirstOrDefault(f => f.Name == UpdateName);
                if (food == null)
                {
                    Console.WriteLine("Food not found");
                    return;
                }
                newPrice = (float)food.Price;
            }
            else
            {
                newPrice = float.Parse(newPriceInput);
            }
            FoodContext context = new FoodContext();
            Food foodToUpdate = context.Foods.FirstOrDefault(f => f.Name == UpdateName);
            if (foodToUpdate == null)
            {
                Console.WriteLine("Food not found");
            }
            else
            {
                foodToUpdate.Price = newPrice;
                context.SaveChanges();
                Console.WriteLine("Food updated successfully");
            }
        }
    }
}
