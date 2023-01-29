using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmProduceManagementApp.models
{
    public class Farmer
    {
        public int Id{ get; set; }
        public int UserId{ get; set; }
        public string FarmerRegNo { get; set; }
        public double Wallet{ get; set; }
        public string Role { get; set; }

        public Farmer(int id, int userId, string farmerRegNo, double wallet, string role)
        {
            Id = id;
            UserId = userId;
            FarmerRegNo = farmerRegNo;
            Wallet = wallet;
            Role = role;
        }
    }
}