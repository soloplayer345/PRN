using Lab2.Model;

namespace Lab2.Controller
{
    internal class CustomerController
    {
        List<Food> cartList = new List<Food>();
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
                //Console.WriteLine("Enter quantity: ");
                //int quantity = int.Parse(Console.ReadLine());
                cartList.Add(food);
            }
        }
        public void viewCart() {
            double sum = 0;
            foreach (Food food in cartList)
            {
                Console.WriteLine($"{food.Name} - {food.Price}");
                sum=sum+food.Price;
            }
            Console.WriteLine($"sum: {sum}VND");
        }
    }
}
