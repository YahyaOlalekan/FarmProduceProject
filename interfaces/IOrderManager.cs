using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.interfaces
{
    public interface IOrderManager
    {
        public Order SearchOrder(int id);
        public Order SearchOrder(string refNumber);
        public void GetAllOrders();
        public void OrderReady(string refNumber);
        public void CancelOrder(string refNumber);
        public void MakeOrder(string customerEmail, double totalPrice, Dictionary<string, int> produces);

    }
}