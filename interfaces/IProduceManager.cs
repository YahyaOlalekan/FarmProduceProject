using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.interfaces
{
    public interface IProduceManager
    {
         public void Addproduct(string productName, string serialNumber, double price, int quantity);
        public Produce GetProduct(int id);
        public Produce GetProduct(string productName);
        public void GetAllProducts();
    }
}