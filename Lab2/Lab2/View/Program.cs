using System.Collections;
namespace Lab2.View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to HighLand Coffee");
            Console.WriteLine("Are you guest or staff: ");
            ArrayList role = new ArrayList();
            role.Add("Guest");
            role.Add("Staff");
            Menu choice = new Menu();
            int roleChoice = choice.GetIntChoice(role);
            switch (roleChoice)
            {
                case 1:
                    Console.WriteLine("Guest");
                    break;
                case 2:
                    Console.WriteLine("Please enter your password: ");
                    string password = Console.ReadLine();
                    if (password == "123")
                    {
                        ArrayList action = new ArrayList();
                        action.Add("Add new food");
                        action.Add("Update food");
                        action.Add("Delete food");
                        action.Add("View all food");
                        action.Add("Exit");
                        int actionChoice = choice.GetIntChoice(action);
                        switch(actionChoice)
                        {
                            case 1:
                                Console.WriteLine("Add new food");
                                break;
                            case 2:
                                Console.WriteLine("Update food");
                                break;
                            case 3:
                                Console.WriteLine("Delete food");
                                break;
                            case 4:
                                Console.WriteLine("View all food");
                                break;
                            case 5:
                                Console.WriteLine("Exit");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong password");
                    }
                    break;
            }
        }
    }
}
