using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.interfaces
{
    public interface IProduceManager
    {
         public void Addproduce(string productName, double price, int quantity, ProduceCategory category, int farmerId);
        public Produce GetProduceById(int id , int categoryId,double quantity);
        public Produce GetProduceByProduceName(string productName);
        public void GetAllProduces();
        public void GetProduceByProduceNameMenu();
        public string GenerateSerialNumber();
        List<Produce> GetProducesByfarmerId(int farmerId);
        

    }
}