using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.implementations;
using FarmProduceManagementApp.interfaces;

namespace FarmProduceManagementApp.menu
{
    public class ManagerMenu
    {

        IManagerManager managerManager = new ManagerManager();
        IOrderManager orderManager = new OrderManager();
        IProduceManager produceManager = new ProduceManager();
        ICustomerManager customerManager = new CustomerManager();
        ProduceMenu produceMenu = new ProduceMenu();
        CustomerMenu customerMenu = new CustomerMenu();

        public void RealManagerMenu()
        {
            Console.WriteLine("Enter 1 to search order by reference number\nEnter 2 to view all orders\nEnter 3 to get produce by its name\nEnter 4 to get all produces\nEnter 5 to search customer by email\nEnter 6 to view all customers");
            int opt = int.Parse(Console.ReadLine());

            if (opt == 1)
            {
                orderManager.SearchOrderByRefNumberMenu();
            }
            else if (opt == 2)
            {
                orderManager.GetAllOrders();
            }
            else if (opt == 3)
            {
                produceManager.GetProduceByProduceNameMenu();
            }
            else if (opt == 4)
            {
                produceManager.GetAllProduces();
            }
            else if (opt == 5)
            {
                customerMenu.SearchCustomerByEmailMenu();
            }
            else if (opt == 6)
            {
                customerManager.GetAllCustomers();
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

        }

        public void SearchManagerByStaffRegNoMenu()
        {
            Console.WriteLine("Enter the registration number of the manager ");
            string regNo = Console.ReadLine();
            var manager = managerManager.SearchManagerByStaffRegNo(regNo);

            Console.WriteLine($" You have searched for {manager.Name}, having an email of {manager.Email}, id number {manager.Id}, pin {manager.Pin}, phone number {manager.PhoneNumber} with an address {manager.Address}");

        }

        public void ManagerSignUpMenu()
        {
            Console.WriteLine("====Registration Of Manager====");
            Console.Write("Enter the following information about the manager: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();


            Console.Write("Pin: ");
            int pin = int.Parse(Console.ReadLine());

            Console.Write("Enter 1 for male, 2 for female: ");
            Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());


            managerManager.RegisterManager(name, email, address, phoneNumber, pin, gender);
            Console.WriteLine();
        }

    }
}