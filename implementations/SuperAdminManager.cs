using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.interfaces;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.implementations
{
    public class SuperAdminManager : ISuperAdminManager
    {
        public static List<SuperAdmin> superAdminDataBase = new List<SuperAdmin>{
        new SuperAdmin(1, "CLH/STF/001", "SuperAdmin", "olabisi", "olabisi@gmail.com", "abk", "08132759937", 123, Gender.Male)
       };

        public SuperAdmin SearchSuperAdminByEmailAndPassWord(string email, int passwd)
        {
             foreach (var superAdmin in superAdminDataBase)
            {
                if ( superAdmin.Email == email && superAdmin.Pin == passwd)
                {
                    return superAdmin;
                }
            }
            return null;
        }

        

        //     public SuperAdmin SearchByEmail(string email)
        // {
        //     var user = userManager.SearchUserByEmail(email);
        //     foreach (var superAdmin in superAdminDataBase)
        //     {
        //         if (superAdmin.UserId == user.Id)
        //         {
        //             return superAdmin;
        //         }
        //     }
        //     return null;
        // }



        public void UpdateProfile(string name, string email, Gender gender, string address, string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}