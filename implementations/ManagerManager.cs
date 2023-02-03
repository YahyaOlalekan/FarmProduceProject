using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.interfaces;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.implementations
{
    public class ManagerManager : IManagerManager
    {
       public static List<Manager> managerDataBase = new List<Manager>();
    //    IUserManager userManager = new UserManager();
        // public void GetAllmanagers()
        // {
        //     foreach(var manager in managerDataBase)
        //     {
        //         var user = userManager.SearchUserById(manager.UserId);
        //         Console.WriteLine($"{user.Name}\t{manager.StaffRegNo}\t{user.Address}\t{user.PhoneNumber}");
            
        //     }
        // }

        

        private string GenerateManagererRegNo()
        {
            return "CLH/MGR/00"+(managerDataBase.Count + 1).ToString();
        }

        // public Manager SearchManagerByEmail(string email)
        // {
        //     var user = userManager.SearchUserByEmail(email);
        //     foreach(var manager in managerDataBase)
        //     {
        //         if(manager.UserId == user.Id)
        //         {
        //             return manager;
        //         }
        //     }
        //     return null;

        // }

        public Manager SearchManagerById(int id)
        {
            foreach(var manager in managerDataBase)
            {
                if(manager.Id == id)
                {
                    return manager;
                }
            }
            return null;
        }

        public Manager SearchManagerByStaffRegNo(string staffRegNo)
        {
             foreach(var manager in managerDataBase)
            {
                if(manager.StaffRegNo == staffRegNo)
                {
                    return manager;
                }
            }
            return null;
        }

       

        public void RegisterManager(string name, string email, string address, string phoneNumber, int pin, Gender gender)
        {
            var manager = new Manager(managerDataBase.Count + 1, GenerateManagererRegNo(),  "Manager", 0, name, email, address,phoneNumber, pin, gender);
            managerDataBase.Add(manager);
            Console.WriteLine($"{name} registered successfully, his staff registration number is {manager.StaffRegNo}");
        }

        public void GetAllmanagers()
        {
            foreach(var manager in managerDataBase)
            {
                Console.WriteLine($"{manager.Name}  has a staff registration number {manager.StaffRegNo}");
            }
        }
    }
}