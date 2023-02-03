using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmProduceManagementApp.implementations;
using FarmProduceManagementApp.interfaces;
using FarmProduceManagementApp.enums;

namespace FarmProduceManagementApp.menu
{
    public class SuperAdminMenu
    {
       IManagerManager managerManager = new ManagerManager();
       IFarmerManager farmerManager = new FarmerManager();
        ManagerMenu managerMenu = new ManagerMenu();

       
       
        public void RealSuperAdminMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Enter 1 to register manager\nEnter 2 to search for the manager by staff registration number\nEnter 3 to view all the managers\nEnter 4 to update farmer registration");
            int opt = int.Parse(Console.ReadLine());

            if(opt == 1)
            {
                managerMenu.ManagerSignUpMenu();
            }
            else if(opt == 2)
            {
                managerMenu.SearchManagerByStaffRegNoMenu();
            }
            else if(opt == 3)
            {
                managerManager.GetAllmanagers();
            }
            else if(opt == 4)
            {
                farmerManager.UpdateFarmerStatusMenu();
            }
            // else if(opt == 3)
            // {
                //add update manager
            // }
            else
            {
                Console.WriteLine("Invalid input");
            }
            RealSuperAdminMenu();
        }
    }
}