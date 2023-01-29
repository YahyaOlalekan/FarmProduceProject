using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmProduceManagementApp.models
{
    public class Manager
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string StaffRegNo { get; set; }
        public double Wallet { get; set; }
        public string Role { get; set; }

        public Manager(int id, int userId, string staffRegNo, double wallet, string role)
        {
            Id = id;
            UserId = userId;
            StaffRegNo = staffRegNo;
            Wallet = wallet;
            Role = role;
        }
    }
}