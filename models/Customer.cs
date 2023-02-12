using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;

namespace FarmProduceManagementApp.models
{
    public class Customer : User
    {
        //public int Id{ get; set; }
       // public int UserId{ get; set; }
        public string CustomerRegNo { get; set; }
        public double Wallet{ get; set; }
        public string Role { get; set; }

        public Customer( string customerRegNo, double wallet, string role , int id, string name, string email, string address, string phoneNumber, int pin, Gender gender) : base(id, name, email, address, phoneNumber, pin, gender)
        {
            
            CustomerRegNo = customerRegNo;
            Wallet = wallet;
            Role = role;
        }
    }
}