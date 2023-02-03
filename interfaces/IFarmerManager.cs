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
        //public void RegisterFarmer();
        public Farmer SearchFarmerById(int id);
        public Farmer SearchFarmerByRegNo(string regNo);
        //public Farmer SearchFarmerByEmail(string email);
        //        public void GetAllFarmers();

        // public void UpdateFarmerRegStatus(string email, FarmerRegStatus farmerRegStatus);

        void UpdateFarmerStatusMenu();
        string GetFarmerRegNumber();
        void RegisterFarmer(string name, string email, int pin, Gender gender, string address, string phoneNumber);
        Farmer SearchFarmerByEmailAndPassWord(string email , int passwd);


    }
}