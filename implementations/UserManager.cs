using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.models;
using FarmProduceManagementApp.interfaces;

namespace FarmProduceManagementApp.implementations
{
    public class UserManager : IUserManager
    {
        public static List<User> userDataBase = new List<User>{
        new User(1, "Ola", "ola@gmail.com", "abk", "08132759937", 123, Gender.Male)
       };



        public User RegisterUser(string name, string email, int pin, Gender gender, string address, string phoneNumber)
        {
            var userExists = CheckIfExists(email);
            if(userExists != null)
            {
                Console.WriteLine($"{userExists.Name}, you are already exists as a user!");
                return null;
            }
            else
            {
                var user = new User(userDataBase.Count + 1, name, email, address, phoneNumber, pin, gender);
                userDataBase.Add(user);
                Console.WriteLine($"{user.Name}, your registration is successful");
                return user;
            }
        }

        public User Login(string email, int pin)
        {
            foreach (var user in userDataBase)
            {
                if (user.Email == email && user.Pin == pin)
                {
                    return user;
                }
            }
            return null;
        }

        public User SearchUser(int id)
        {
            foreach (var user in userDataBase)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }
        public User SearchUser(string email)
        {
            foreach (var user in userDataBase)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }

        private User CheckIfExists(string email)
        {
            foreach (var user in userDataBase)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }
    }
}