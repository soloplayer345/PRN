using System.Collections;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("12");
            list.Add("13");
            list.Add("14");
            Menu menu = new Menu();
            int choice = menu.getIntChoice(list);
            Console.WriteLine("Hello, World!");
        }
    }
}
