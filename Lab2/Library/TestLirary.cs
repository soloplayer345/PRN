using Lab2;
using System.Collections;

namespace Library
{
    internal class TestLirary
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("12");
            list.Add("13");
            list.Add("14");
            Menu menu = new Menu();
            int choice = menu.GetIntChoice(list);
            Console.WriteLine("Hello, World!");
            Console.WriteLine(choice);
        }
    }
}
