using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.enums;
using FarmProduceManagementApp.interfaces;
using FarmProduceManagementApp.models;

namespace FarmProduceManagementApp.implementations
{
    public class ProduceManager : IProduceManager
    {

        public static List<Produce> produceDataBase = new List<Produce>(){
            new Produce(1, "Coffee", "PLT/001", 1000, 20000, ProduceCategory.Plantations, 000),
            new Produce(2, "Cocoa", "PLT/002", 900, 30000, ProduceCategory.Plantations, 000 ),

            new Produce(1, "Groundnut", "OIL/001", 100, 2000, ProduceCategory.OilSeeds, 000 ),
            new Produce(2, "Soybean", "OIL/002", 400, 30000, ProduceCategory.OilSeeds, 000 ),

            new Produce(1, "Rice", "CRL/001", 1000, 10000, ProduceCategory.Cereals, 000 ),
            new Produce(2, "Maize", "CRL/002", 350, 500, ProduceCategory.Cereals, 000),

            new Produce(1, "Apple", "FRT/001", 500, 2000, ProduceCategory.Fruits, 000),
            new Produce(2, "Date palm", "FRT/002", 140, 1000, ProduceCategory.Fruits, 000),
            //new Produce()
        };


        public void Addproduce(string produceName, double price, int quantity, ProduceCategory category, int farmerId)
        {
            var produceExists = CheckIfExists(produceName);
            if (produceExists != null)
            {
                produceExists.Quantity += quantity;
                Console.WriteLine("The quantity is successfully updated");
                Console.WriteLine();

            }
            else
            {
                var produce = new Produce(produceDataBase.Count + 1, produceName, GenerateSerialNumber(), price, quantity, category, farmerId);
                
                produceDataBase.Add(produce);
                //Console.WriteLine($"{farmerId}\t{produceDataBase.Count}");
                Console.WriteLine($"{produce.ProduceName} added successfully, quantity in stock is {produce.Quantity}");
                Console.WriteLine();
            }
        }

        private Produce CheckIfExists(string produceName)
        {
            foreach (var produce in produceDataBase)
            {
                if (produce.ProduceName == produceName)
                {
                    return produce;
                }
            }
            return null;
        }

        public void GetAllProduces()
        {
            foreach (var produce in produceDataBase)
            {
                Console.WriteLine($"produce name:{produce.ProduceName}\t\tserial number:{produce.SerialNumber}\t\tquantity:{produce.Quantity}");
            }
        }

        public List<Produce> GetProducesByfarmerId(int farmerId)
        {
            List<Produce> produces = new List<Produce>();
            foreach (var produce in produceDataBase)
            {
                if (produce.FarmerId == farmerId)
                {
                    produces.Add(produce);
                    
                }

            }
            return produces;
        }

        public Produce GetProduceById(int id , int categoryId , double quantity)
        {
            foreach (var produce in produceDataBase)
            {
                if (produce.Id == id && (int)produce.Category == categoryId && produce.Quantity >= quantity)
                {
                    return produce;
                }
            }
            return null;
        }

        public Produce GetProduceByProduceName(string produceName)
        {
            foreach (var produce in produceDataBase)
            {
                if (produce.ProduceName == produceName)
                {
                    return produce;
                }
            }
            return null;
        }

       
        // public string GenerateSerialNumber()
        // {
        //     Random rand = new Random();
        //     return "SN/" + (rand.Next(0, 100));
        // }
        public string GenerateSerialNumber()
        {
            return "SN/00" + (produceDataBase.Count + 1);
        }

        public void GetProduceByProduceNameMenu()
        {
            throw new NotImplementedException();
        }
    }
}