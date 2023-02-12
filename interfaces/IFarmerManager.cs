using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.interfaces
{
    public interface IFarmerManager
    {
        public Farmer SearchFarmerById(int id);
        public Farmer SearchFarmerByRegNo(string regNo);
        void UpdateFarmerStatusMenu();
        string GetFarmerRegNumber();
        void RegisterFarmer(string name, string email, int pin, Gender gender, string address, string phoneNumber);
        Farmer SearchFarmerByEmailAndPassWord(string email , int passwd);

    }
}