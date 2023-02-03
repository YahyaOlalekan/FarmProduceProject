using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;

namespace FarmProduceManagementApp.models
{
    public class Produce
    {
        public int Id { get; set; }
        public string ProduceName { get; set; }
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public ProduceCategory Category { get; set; }
        public int FarmerId { get; set; }

        public Produce(int id, string produceName, string serialNumber, double price, double quantity, ProduceCategory category, int farmerId)
        {
            Id = id;
            ProduceName = produceName;
            SerialNumber = serialNumber;
            Price = price;
            Quantity = quantity;
            Category = category;
            FarmerId = farmerId;
        }
    }
}