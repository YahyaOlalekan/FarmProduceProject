using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmProduceManagementApp.models
{
    public class Produce
    {
         public int Id{ get; set; }
        public string ProduceName{ get; set; }
        public string SerialNumber{ get; set; }
        public double Price{ get; set; }
        public int Quantity{ get; set; }

        public Produce(int id, string produceName, string serialNumber, double price, int quantity)
        {
            Id = id;
            ProduceName = produceName;
            SerialNumber = serialNumber;
            Price = price;
            Quantity = quantity;
        }
    }
}