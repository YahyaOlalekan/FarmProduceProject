using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;

namespace FarmProduceManagementApp.models
{
    public class SuperAdmin : User
    {
        // public int Id { get; set; }
        //public int UserId { get; set; }
        public string StaffRegNo { get; set; }
        public string Role { get; set; }

        public SuperAdmin(int id, string staffRegNo, string role, string name, string email, string address, string phoneNumber, int pin, Gender gender) : base(id, name, email, address, phoneNumber, pin, gender)
        {
            //Id = id;
            // UserId = userId;
            StaffRegNo = staffRegNo;
            Role = role;
        }
    }
}