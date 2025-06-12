using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliverySystem.services;
using FoodDeliverySystem.modules;

namespace FoodDeliverySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your test code
            DeliveryStaff driver = new DeliveryStaff(3, "Charlie", "Bike");
            Console.WriteLine("Delivery Driver Info:");
            Console.WriteLine("ID: " + driver.GetId());
            Console.WriteLine("Name: " + driver.GetName());
            Console.WriteLine("Vehicle: " + driver.GetVehicle());
            

            // 👇 This line keeps the console window open
            Console.ReadLine();

        }
    }

}


