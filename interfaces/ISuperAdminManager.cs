using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.interfaces
{
    public interface ISuperAdminManager
    {
        public void UpdateProfile(string name, string email, Gender gender, string address, string phoneNumber);
        public SuperAdmin Search(string email);
    }
}