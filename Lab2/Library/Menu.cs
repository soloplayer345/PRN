using Library;
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
        public String GetNumberChoice(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{list.IndexOf(item)+1} : {item}");
            }
            Console.WriteLine($"Please choose 1 to {list.Count}: ");
            Console.WriteLine("---------------------------");
            return Console.ReadLine();
        }
    }
}
