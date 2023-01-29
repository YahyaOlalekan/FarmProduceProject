using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.interfaces
{
    public interface IManagerManager
    {
         public void RegisterManager();
        public Manager SearchManager(int id);
        public Manager SearchManager(string staffRegNo);
        public Manager Search(string email);
        public void GetAllmanagers();
    }
}