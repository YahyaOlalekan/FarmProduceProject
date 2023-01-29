using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.interfaces;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.implementations
{
    public class OrderManager : IOrderManager
    {
        public void CancelOrder(string refNumber)
        {
            throw new NotImplementedException();
        }

        public void GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public void MakeOrder(string customerEmail, double totalPrice, Dictionary<string, int> produces)
        {
            throw new NotImplementedException();
        }

        public void OrderReady(string refNumber)
        {
            throw new NotImplementedException();
        }

        public Order SearchOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Order SearchOrder(string refNumber)
        {
            throw new NotImplementedException();
        }
    }
}