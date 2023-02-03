using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.interfaces;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.implementations
{
    public class FarmerManager : IFarmerManager
    {
        public static List<Farmer> farmersDataBase = new List<Farmer>();
     
 

        // public void GetAllFarmers()
        // {
        //     foreach (var farmer in farmersDataBase)
        //     {
        //         var user = userManager.SearchUserById(farmer.UserId);
        //         Console.WriteLine($"{user.Name}\t{farmer.FarmerRegNo}\t{user.Address}\t{user.PhoneNumber}");
        //     }
        // }

        public string GetFarmerRegNumber()
        {
            //Random random = new Random();
          // return "FAR/"+(random.Next(0, 100));
           return "FAR/00"+(farmersDataBase.Count + 1);
        }

        public void RegisterFarmer(string name, string email, int pin, Gender gender, string address, string phoneNumber)
        {
            var farmer = new Farmer(farmersDataBase.Count + 1, GenerateFarmerRegNo(), 0, "Farmer" , FarmerRegStatus.Pending, name , email , address , phoneNumber ,  pin , gender);
            farmersDataBase.Add(farmer);

            Console.WriteLine($"Dear {name}, you have been sucessfully registered, your registration number is {farmer.FarmerRegNo} and your wallet balance is {farmer.Wallet}");
        }

        private string GenerateFarmerRegNo()
        {
            return "CLH/CTM/00" + (farmersDataBase.Count + 1).ToString();
        }
        
        // public void RegisterFarmer()
        // {
        //     var farmer = new Farmer(farmersDataBase.Count + 1, UserManager.userDataBase.Count, GetFarmerRegNumber(), 0.00, "farmer", FarmerRegStatus.Pending);
        //     farmersDataBase.Add(farmer);

        //     var user = userManager.SearchUserById(farmer.UserId);
        //     Console.WriteLine($"Dear {user.Name}, you have been sucessfully registered, your registration number is {farmer.FarmerRegNo} and your wallet balance is #{farmer.Wallet}");

        // }



        // public Farmer SearchFarmerByEmail(string email)
        // {
        //     var user = userManager.SearchUserByEmail(email);

        //     foreach (var farmer in farmersDataBase)
        //     {
        //         //Console.WriteLine($"{farmer.UserId} {user.Id}");
        //         if (farmer.UserId == user.Id)
        //         {
        //             return farmer;
        //         }
        //     }
        //     return null;
        // }

        public Farmer SearchFarmerById(int id)
        {
            foreach (var farmer in farmersDataBase)
            {
                if (farmer.Id == id)
                {
                    return farmer;
                }
            }
            return null;
        }

        public Farmer SearchFarmerByRegNo(string regNo)
        {
            foreach (var farmer in farmersDataBase)
            {
                if (farmer.FarmerRegNo == regNo)
                {
                    return farmer;
                }
            }
            return null;
        }

        // public void UpdateFarmerRegStatus(string email, FarmerRegStatus farmerRegStatus)
        // {
        //     var user = userManager.SearchUserByEmail(email);
        //     foreach (var farmer in farmersDataBase)
        //     {
        //         if (farmer.UserId == user.Id)
        //         {
        //             farmer.FarmerRegStatus = farmerRegStatus;
        //         }
        //     }
        // }

        public void UpdateFarmerStatusMenu()
        {
            throw new NotImplementedException();
        }

       

         public Farmer SearchFarmerByEmailAndPassWord(string email, int passwd)
        {
            foreach (var farmer in farmersDataBase)
            {
                if (farmer.Email == email && farmer.Pin == passwd)
                {
                    return farmer;
                }
            }
            return null;
        }

       
    }
}