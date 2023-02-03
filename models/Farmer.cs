using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;

namespace FarmProduceManagementApp.models
{
    public class Farmer : User
    {
       // public int Id{ get; set; }
       // public int UserId{ get; set; }
        public string FarmerRegNo { get; set; }
        public double Wallet{ get; set; }
        public string Role { get; set; }
        public FarmerRegStatus FarmerRegStatus {get; set;}

        public Farmer(int id, string farmerRegNo, double wallet, string role, FarmerRegStatus farmerRegStatus, string name, 
        string email, string address, string phoneNumber, int pin, Gender gender) : base(id, name, email, address, phoneNumber, pin, gender)
        {
        
            FarmerRegNo = farmerRegNo;
            Wallet = wallet;
            Role = role;
            FarmerRegStatus = farmerRegStatus;
        }

        
    }
}