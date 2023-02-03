using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.implementations;
using FarmProduceManagementApp.interfaces;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.menu
{
    public class CustomerMenu
    {
        IProduceManager produceManager = new ProduceManager();
        IOrderManager orderManager = new OrderManager();
        ICustomerManager customerManager = new CustomerManager();
        
        
        public void RealCustomerMenu()
        {
            MainMenu mainMenu = new MainMenu();
            Console.WriteLine();
            Console.WriteLine("======Customer Menu======");
            Console.WriteLine("Enter 1 to view all produce\nEnter 2 to make order\nEnter 3 to fund wallet\nEnter 4 to check wallet balance\nEnter 0 to go back");
            int option = int.Parse(Console.ReadLine());

        
            if (option == 0)
            {
                mainMenu.RealMenu();
            }
            else if (option == 1)
            {
                produceManager.GetAllProduces();
            }
            else if (option == 2)
            {
                MakeOrderMenu();
            }
            else if (option == 3)
            {
                FundWallet();
            }
            else if (option == 4)
            {
                CheckWalletBalance();
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
            
            RealCustomerMenu();
        }

        public void SearchCustomerByEmailMenu()
        {
            Console.WriteLine("Enter the email ");
            string email = Console.ReadLine();
            customerManager.SearchCustomerByEmail(email);
        }
        public string FundWallet()
        {
            Console.WriteLine("Enter the email ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter the password ");
            int passwd = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount to deposit ");
            double amount = double.Parse(Console.ReadLine());
            var customer = customerManager.SearchCustomerByEmailAndPassWord(email, passwd);
            

            if (customer == null)
            {
                Console.WriteLine("You don't have wallet!");
            }
            else if(amount <= 0 )
            {
                Console.WriteLine("You don't have enough amount in your wallet!");
                
            }
            customer.Wallet += amount;
            return $"Your balance is #{customer.Wallet} ";
        }

        public void MakeOrderMenu()
        {
            Console.Write("Enter your email address: ");
            string email = Console.ReadLine();

            bool flag = true;
            double totalPrice = 0;
            Dictionary<string, int> produces = new Dictionary<string, int>();
            var enums = Enum.GetValues(typeof(ProduceCategory));
            while (flag)
            {
                Console.WriteLine("Choose from the following categories");
                foreach (var item in enums)
                {
                    Console.WriteLine("Enter {0} for {1}", (int)item, item.ToString());
                }
                int choice = int.Parse(Console.ReadLine());
                foreach (var item in ProduceManager.produceDataBase)
                {
                    if (choice == (int)item.Category)
                    {
                        Console.WriteLine($"Enter {item.Id} to buy {item.ProduceName}");
                    }
                }
                int option = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the quantity : ");
                double quantity = int.Parse(Console.ReadLine());


                var produce = produceManager.GetProduceById(option, choice, quantity);
                var customer = customerManager.SearchCustomerByEmail(email);
                if (produce == null)
                {
                    Console.WriteLine("Quantity requested is more than the stock");
                }
                else if (customer.Wallet < (produce.Quantity * produce.Price))
                {
                    Console.WriteLine("You don't have enough amount in your wallet!");
                    break;
                }
                else
                {
                    customer.Wallet -= (produce.Price * quantity);
                    totalPrice += (produce.Price * quantity);

                    produce.Quantity -= quantity;
                    if (produce.Quantity == 0)
                    {
                        ProduceManager.produceDataBase.Remove(produce);
                    }
                    var id = Transaction.Transactions.Count() == 0 ? 1 : Transaction.Transactions.Count() + 1;
                    Transaction.Transactions.Add(new Transaction(id, produce.Id, produce.Category, produce.ProduceName, email, quantity));
                    Console.WriteLine("Your order is successful");
                }

                Console.WriteLine("Do you want to buy another produce(yes/no): ");
                string opt = Console.ReadLine();
                if (opt.ToLower() == "no")
                {
                    Console.WriteLine($"Your order is successful and the total price is {totalPrice}");
                    flag = false;
                }
            }

            orderManager.MakeOrder(email, totalPrice, produces);
           
            RealCustomerMenu();

        }

        public void CheckWalletBalance()
        {
            Console.WriteLine();
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            
            Console.WriteLine("Enter your password");
            int passwd = int.Parse(Console.ReadLine());
            
            var customer = customerManager.SearchCustomerByEmailAndPassWord(email, passwd);
            if(customer != null)
            {
                Console.WriteLine($"Your wallet balance is {customer.Wallet}"); 
            }
            
        }
    }
}