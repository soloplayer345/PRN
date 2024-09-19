using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Menu
    {
        public int getIntChoice(ArrayList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i+1} : ${list.IndexOf(i)}");
            }
            Console.WriteLine($"Please choose 1 to {list.Count}: ");
            Console.WriteLine("---------------------------");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
