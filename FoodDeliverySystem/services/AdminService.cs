using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliverySystem.modules;

namespace FoodDeliverySystem.services
{
    class AdminService
    {
        private List<Admin> adminList = new List<Admin>();

        // Add admin (id, name, password)
        public void AddAdmin(int id, string name, string password)
        {
            Admin admin = new Admin(id, name, password);
            adminList.Add(admin);
        }

        // Login using name and password (no username in your model)
        public bool Login(string name, string password)
        {
            foreach (Admin a in adminList)
            {
                if (a.GetName() == name && a.GetPassword() == password)
                {
                    Console.WriteLine("Login successful. Welcome, " + a.GetName() + "!");
                    return true;
                }
            }

            Console.WriteLine("Login failed. Invalid name or password.");
            return false;
        }

    }
}
