using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.interfaces;
using FarmProduceManagementApp.implementations;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.menu
{
    public class MainMenu
    {
        public static User _currentUser = null;
        ICustomerManager customerManager = new CustomerManager();
        IFarmerManager farmerManager = new FarmerManager();
        ISuperAdminManager superAdminManager = new SuperAdminManager();
        IManagerManager managerManager = new ManagerManager();

        CustomerMenu customerMenu = new CustomerMenu();
        SuperAdminMenu superAdminMenu = new SuperAdminMenu();
        FarmerMenu farmerMenu = new FarmerMenu();
        ManagerMenu managerMenu = new ManagerMenu();

        public void RealMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to CLH Farm\nEnter 1 for Super Admin to login\nEnter 2 for farmer to sign up\nEnter 3 for customer to sign up");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                var superAdminMenu = new SuperAdminMenu();
                Console.WriteLine();
                LoginMenu();
                Console.WriteLine();
                superAdminMenu.RealSuperAdminMenu();

            }
            else if (option == 2)
            {
                Console.WriteLine();
                FarmerSignUpMenu();
                LoginMenu();
            }
            else if (option == 3)
            {
                Console.WriteLine();
                CustomerSignUpMenu();
                LoginMenu();
            }
            else
            {
                Console.WriteLine("Invalid input!");
                RealMenu();
            }

        }

        public void CustomerSignUpMenu()
        {
            Console.WriteLine("==== SIGN UP ====");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

            Console.Write("Enter 1 for male, 2 for female: ");
            Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());

            Console.Write("Enter your address: ");
            string address = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();


            customerManager.RegisterCustomer(name, email, pin, gender, address, phoneNumber);
            Console.WriteLine();

        }
        public void FarmerSignUpMenu()
        {
            Console.WriteLine("==== SIGN UP ====");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

            Console.Write("Enter 1 for male, 2 for female: ");
            Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());

            Console.Write("Enter your address: ");
            string address = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();

            farmerManager.RegisterFarmer(name, email, pin, gender, address, phoneNumber);

            Console.WriteLine();
        }


        public void LoginMenu()
        {
            Console.WriteLine("==LOGIN ===");
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

            var customerLogin = customerManager.SearchCustomerByEmailAndPassWord(email, pin);
            var farmerLogin = farmerManager.SearchFarmerByEmailAndPassWord(email, pin);
            var superAdminLogin = superAdminManager.SearchSuperAdminByEmailAndPassWord(email, pin);

            if (customerLogin == null && farmerLogin == null && superAdminLogin == null)
            {
                Console.WriteLine("Invalid inputs!");
                RealMenu();
            }

            else if (customerLogin != null)
            {
                _currentUser = customerLogin;
                Console.WriteLine($"Dear {customerLogin.Name}, you have successfully logged in");
                customerMenu.RealCustomerMenu();
            }

            else if (farmerLogin != null)
            {
                _currentUser = farmerLogin;
                Console.WriteLine($"Dear {farmerLogin.Name}, you have successfully logged in ");
                farmerMenu.RealFarmerMenu(farmerLogin.Id);
            }

            else if (superAdminLogin != null)
            {
                Console.WriteLine($"Dear Super Admin, you have successfully logged in ");
            }


        }


    }
}