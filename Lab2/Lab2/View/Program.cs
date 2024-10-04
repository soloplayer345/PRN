using Lab2.Controller;
using Lab2.Model;
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
            String roleChoice = choice.GetNumberChoice(role);
            Boolean continueRole = true;
                switch (roleChoice)
                {
                    case "1":
                    ArrayList cutomerAction = new ArrayList();          
                    CustomerController customerController = new CustomerController();
                    customerController.viewTheMenu();
                    cutomerAction.Add("Order");
                    cutomerAction.Add("Reviewing Cart");
                    cutomerAction.Add("Placing an Order");
                    cutomerAction.Add("Exit");
                    do
                    {
                        string customerChoice = choice.GetNumberChoice(cutomerAction);
                        switch (customerChoice) 
                        {
                            case "1":
                                customerController.orderFood();
                                Console.WriteLine("\n----------------\n");
                                break;
                            case "2":
                                customerController.viewCart();
                                Console.WriteLine("\n----------------\n");
                                break;
                                case"3":
                                //tao io sau
                                    break;
                            case "4":
                                Console.WriteLine("thank you");
                                continueRole = false;
                                break;
                        }
                    }
                    while (continueRole);
                        break;
                    case "2":
                        Console.WriteLine("Please enter your password: ");
                        string password = Console.ReadLine();
                    do
                    {
                        if (password == "123")
                        {
                            AdminController adminController = new AdminController();
                            ArrayList adminAction = new ArrayList();
                            adminAction.Add("Add new food");
                            adminAction.Add("Update food");
                            adminAction.Add("Delete food");
                            adminAction.Add("View all food");
                            adminAction.Add("Exit");
                            string actionChoice = choice.GetNumberChoice(adminAction);
                            switch (actionChoice)
                            {
                                case "1":                                   
                                    adminController.addFood();
                                    Console.WriteLine("\n----------------\n");
                                    break;
                                case "2":                                 
                                    adminController.updateFood();
                                    Console.WriteLine("\n----------------\n");
                                    break;
                                case "3":
                                    adminController.removeFood();
                                    Console.WriteLine("\n----------------\n");
                                    break;
                                case "4":
                                    adminController.viewAllFood();
                                    Console.WriteLine("\n----------------\n");
                                    break;
                                case "5":
                                    continueRole = false;
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong password");
                            continueRole = false;
                        }
                    }
                    while (continueRole);
                        break;
                }
            } 
        }
    }

