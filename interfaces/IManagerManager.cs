using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.interfaces
{
    public interface IManagerManager
    {
        // public void RegisterManager();
       public Manager SearchManagerById(int id);
        public Manager SearchManagerByStaffRegNo(string staffRegNo);
       // public Manager SearchManagerByEmail(string email);
       public void GetAllmanagers();
       public void RegisterManager(string name, string email, string address, string phoneNumber, int pin, Gender gender);//this are the parameters that are not generated internally
    }
}