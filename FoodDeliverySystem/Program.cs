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
            AdminService adminService = new AdminService();

            // Ask user for admin details
            Console.Write("Enter Admin ID (number): ");
            int id = Convert.ToInt32(Console.ReadLine());  //  fix here

            Console.Write("Enter Admin Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Admin Password: ");
            string password = Console.ReadLine();

            // Now call method correctly
            adminService.AddAdmin(id, name, password);


            // Try to log in
            Console.Write("\nLogin - Enter Name: ");
            string loginName = Console.ReadLine();

            Console.Write("Enter Password: ");
            string loginPassword = Console.ReadLine();

            adminService.Login(loginName, loginPassword);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }

}


