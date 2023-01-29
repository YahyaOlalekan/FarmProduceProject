using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;

namespace FarmProduceManagementApp.models
{
    public class Order
    {
        public int Id{ get; set; }
        public string RefNumber{ get; set; }
        public string CustomerEmail{ get; set; }//remove
        public double TotalPrice{ get; set; }
        public DeliveryStatus Status{ get; set; }
        public Dictionary<string, int> Produce { get; set; }

        public Order(int id, string refNumber, string customerEmail, double totalPrice, DeliveryStatus status, Dictionary<string, int> produce)
        {
            Id = id;
            RefNumber = refNumber;
            CustomerEmail = customerEmail;
            TotalPrice = totalPrice;
            Status = status;
            Produce = produce;
        }
    }
}