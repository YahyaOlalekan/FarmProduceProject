using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.models;
using FarmProduceManagementApp.enums;

namespace FarmProduceManagementApp.interfaces
{
    public interface IUserManager
    {
        public User RegisterUser(string name, string email, int pin, Gender gender, string address, string phoneNumber);
        public User Login(string email, int pin);
        public User SearchUser(int id);
        public User SearchUser(string email);
    }
}
