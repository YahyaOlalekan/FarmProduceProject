using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;

namespace FarmProduceManagementApp.models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int Pin { get; set; }
        public Gender Gender { get; set; }

        public User(int id, string name, string email, string address, string phoneNumber, int pin, Gender gender)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
            Pin = pin;
            Gender = gender;
        }
    }

    
}