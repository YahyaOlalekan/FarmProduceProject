using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.interfaces;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.implementations
{
    public class CustomerManager : ICustomerManager
    {
        public static List<Customer> customerDataBase = new List<Customer>();
       IUserManager userManager = new UserManager();
        public void GetAllCustomers()
        {
            foreach(var customer in customerDataBase)
            {
                var user = userManager.SearchUser(customer.UserId);
                Console.WriteLine($"{user.Name}\t{customer.CustomerRegNo}\t{user.Address}\t{user.PhoneNumber}");
            }
        }

        public void RegisterCustomer()
        {
            var customer = new Customer(customerDataBase.Count + 1, UserManager.userDataBase.Count, GenerateRegNo(), 0, "Customer")
        }

        public Customer Search(string email)
        {
            throw new NotImplementedException();
        }

        public Customer SearchCustomer(int id)
        {
            throw new NotImplementedException(); 
        }

        public Customer SearchCustomer(string regNo)
        {
            throw new NotImplementedException();
        }
    }
}