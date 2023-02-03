using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.interfaces
{
    public interface ICustomerManager
    {
        public void RegisterCustomer(string name, string email, int pin, Gender gender, string address, string phoneNumber);
        public Customer SearchCustomerById(int id);
        public Customer SearchCustomerByEmailAndPassWord(string email , int passwd);
        public Customer SearchCustomerByRegNo(string regNo);
        public Customer SearchCustomerByEmail(string email);
        public void GetAllCustomers();

    }
}