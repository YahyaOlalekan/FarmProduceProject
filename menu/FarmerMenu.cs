using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.implementations;
using FarmProduceManagementApp.interfaces;

namespace FarmProduceManagementApp.menu
{

    public class FarmerMenu
    {
        IFarmerManager farmerManager = new FarmerManager();
        IProduceManager produceManager = new ProduceManager();
        public void RealFarmerMenu(int farmerId)
        {
            Console.WriteLine();
            Console.WriteLine("===Farmer Menu====");
            Console.WriteLine("Enter 1 to add produce that you want to sell\nEnter 2 to view produce\nEnter 3 to go back to the main menu");
            int opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                AddproduceMenu(farmerId);
            }
            else if (opt == 2)
            {
                var produces = produceManager.GetProducesByfarmerId(farmerId);
                if (produces.Count > 0)
                {
                    foreach (var produce in produces)
                    {
                        Console.WriteLine($"{produce.ProduceName}\t\tSerial number:{produce.SerialNumber}\t\tQuantity:{produce.Quantity}");
                    }
                }
                else
                {
                    Console.WriteLine("You have not added any produce!");
                }

                RealFarmerMenu(farmerId);
            }
            else if (opt == 3)
            {
                var mainMenu = new MainMenu();
                Console.WriteLine();
                mainMenu.RealMenu();
            }
        }

        public void UpdateFarmerStatusMenu()
        {
            Console.Write("Enter your email");
            string email = Console.ReadLine();
            Console.Write("Enter status (1 for Approval, 2 for Cancel) ");
            int status = int.Parse(Console.ReadLine());
            //farmerManager.UpdateFarmerRegStatus(email, (FarmerRegStatus)status);
        }

        public void AddproduceMenu(int farmerId)
        {

            Console.WriteLine();
            Console.WriteLine("Enter the category of produce you want to input");
            Console.WriteLine("Enter 1 for plantations, 2 for oilseeds, 3 for cereals and 4 for fruits: ");
            int opt = int.Parse(Console.ReadLine());
            // ProduceCategory produceCategory = ProduceCategory.Plantations;

            Console.Write("Enter the produce name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the price you want to sell your produce: ");
            double price = double.Parse(Console.ReadLine());

            string nameOfCategory = ((ProduceCategory)opt).ToString();

            double setPrice = (int)Enum.Parse(typeof(ProduceCategoryPrices), nameOfCategory);
            bool flag = (price > (setPrice + 100));
            int countAsking = 0;
            if (flag)
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine($"#{price} is too exorbitant for this category");
                    Console.Write("Enter the price that you want to sell your produce: ");
                    price = double.Parse(Console.ReadLine());
                    countAsking++;
                    if (countAsking >= 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"The price shouidn't be more than #{setPrice + 100} for this category");
                        Console.WriteLine("Do you still want to sell your produce(Yes/No) ");
                        string response = Console.ReadLine();
                        if (response.ToLower() == "no")
                        {
                            Console.WriteLine("Thank you, bye for now");
                            

                        }
                        else
                        {
                            Console.Write("Enter the price that you want to sell your produce: ");
                            price = double.Parse(Console.ReadLine());
                            if (!(price > (setPrice + 100)))
                            {
                                Console.Write("Enter the quantity: ");
                                int quantity = int.Parse(Console.ReadLine());
                                produceManager.Addproduce(name, price, quantity, (ProduceCategory)opt, farmerId);
                                break;
                            }
                        }
                    }
                }

            }
            else
            {
                Console.Write("Enter the quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                produceManager.Addproduce(name, price, quantity, (ProduceCategory)opt, farmerId);
            }



            RealFarmerMenu(farmerId);
            Console.WriteLine();



        }


    }
}