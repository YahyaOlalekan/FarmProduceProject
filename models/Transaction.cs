using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;

namespace FarmProduceManagementApp.models
{
    public class Transaction
    {

        public Transaction(int id, int productId, ProduceCategory category, string productName, string email, double quantity)
        {
            Id = id;
            ProductId = productId;
            Category = category;
            ProductName = productName;
            Email = email;
            Quantity = quantity;
        }
        public static IList<Transaction> Transactions = new List<Transaction>();
        public int Id { get; set; }
        public int ProductId { get; set; }
        public ProduceCategory Category { get; set; }
        public string ProductName { get; set; }
        public string Email { get; set; }
        public double Quantity { get; set; }

    }
}