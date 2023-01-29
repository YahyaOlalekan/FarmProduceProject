using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.interfaces
{
    public interface ICustomerManager
    {
        public void RegisterCustomer();
        public Customer SearchCustomer(int id);
        public Customer SearchCustomer(string regNo);
        public Customer Search(string email);
        public void GetAllCustomers();

    }
}