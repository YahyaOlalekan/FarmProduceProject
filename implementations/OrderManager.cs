using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.interfaces;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.implementations
{
    public class OrderManager : IOrderManager
    {
        public static List<Order> ordersDataBase = new List<Order>();

        public void CancelOrderByRefNumber(string refNumber)
        {
            foreach (var order in ordersDataBase)
            {
                if (order.RefNumber == refNumber)
                {
                    order.Status = DeliveryStatus.Cancel;
                }
            }
        }

        public void GetAllOrders()
        {
            foreach (var order in ordersDataBase)
            {
                Console.WriteLine($"{order.CustomerEmail}\t{order.RefNumber}\t{order.Status}\t{order.TotalPrice}");
                foreach (var item in order.Produce)
                {
                    Console.WriteLine($"{item.Key}\t{item.Value}");
                }
            }
        }

        public void MakeOrder(string customerEmail, double totalPrice, Dictionary<string, int> produces)
        {
            Order order = new Order(ordersDataBase.Count + 1, GenerateReferenceNumber(), customerEmail, totalPrice, DeliveryStatus.Initiated, produces);
            ordersDataBase.Add(order);
        }

        private string GenerateReferenceNumber()
        {
            Random rand = new Random();
            return $"CLH/PRO/{rand.Next(1000000, 10000000)}";
        }

        public void SearchIfOrderReadyByRefNumber(string refNumber)
        {
            foreach (var order in ordersDataBase)
            {
                if (order.RefNumber == refNumber)
                {
                    order.Status = DeliveryStatus.Ready;
                }
            }
        }

        public Order SearchOrderById(int id)
        {
            foreach (var order in ordersDataBase)
            {
                if (order.Id == id)
                {
                    return order;
                }
            }
            return null;
        }

        public Order SearchOrderByRefNumber(string refNumber)
        {
            foreach (var order in ordersDataBase)
            {
                if (order.RefNumber == refNumber)
                {
                    return order;
                }
            }
            return null;
        }

        public void SearchOrderByRefNumberMenu()
        {
            throw new NotImplementedException();
        }
    }
}