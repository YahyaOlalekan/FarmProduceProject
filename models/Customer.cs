using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmProduceManagementApp.models
{
    public class Customer
    {
        public int Id{ get; set; }
        public int UserId{ get; set; }
        public string CustomerRegNo { get; set; }
        public double Wallet{ get; set; }
        public string Role { get; set; }

        public Customer(int id, int userId, string customerRegNo, double wallet, string role)
        {
            Id = id;
            UserId = userId;
            CustomerRegNo = customerRegNo;
            Wallet = wallet;
            Role = role;
        }
    }
}