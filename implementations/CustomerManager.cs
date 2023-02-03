using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.interfaces;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.implementations
{
    public class CustomerManager : ICustomerManager
    {
        public static List<Customer> customerDataBase = new List<Customer>();
        
        public void GetAllCustomers()
        {
            foreach (var customer in customerDataBase)
            {
               
                Console.WriteLine($"{customer.Name}\t{customer.CustomerRegNo}\t{customer.Address}\t{customer.PhoneNumber}");
            }
        }

        public void RegisterCustomer(string name, string email, int pin, Gender gender, string address, string phoneNumber)
        {
            var customer = new Customer(GenerateCustomerRegNo(), 0, "Customer" , customerDataBase.Count + 1, name , email , address , phoneNumber ,  pin , gender);
            customerDataBase.Add(customer);

            Console.WriteLine($"Dear {name}, you have been sucessfully registered, your registration number is {customer.CustomerRegNo} and your wallet balance is {customer.Wallet}");
        }

        private string GenerateCustomerRegNo()
        {
            return "CLH/CTM/00" + (customerDataBase.Count + 1).ToString();
        }

        public Customer SearchCustomerByEmail(string email)
        {
           
            foreach (var customer in customerDataBase)
            {
                if (customer.Email == email)
                {
                    return customer;
                }
            }
            return null;
        }

        public Customer SearchCustomerById(int id)
        {
            foreach (var customer in customerDataBase)
            {
                if (customer.Id == id)
                {
                    return customer;
                }
            }
            return null;
        }
        

        public Customer SearchCustomerByRegNo(string regNo)
        {
            foreach (var customer in customerDataBase)
            {
                if (customer.CustomerRegNo == regNo)
                {
                    return customer;
                }
            }
            return null;
        }

        public Customer SearchCustomerByEmailAndPassWord(string email, int passwd)
        {
            foreach (var customer in customerDataBase)
            {
                if (customer.Email == email && customer.Pin == passwd)
                {
                    return customer;
                }
            }
            return null;
        }
    }
}