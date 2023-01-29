using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.interfaces;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.implementations
{
    public class ProduceManager : IProduceManager
    {
        public void Addproduct(string productName, string serialNumber, double price, int quantity)
        {
            throw new NotImplementedException();
        }

        public void GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Produce GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Produce GetProduct(string productName)
        {
            throw new NotImplementedException();
        }
    }
}