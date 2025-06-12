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
            Customer customer = new Customer(1, "Alice", "123 Main St", "9876543210");
            Console.WriteLine("Customer Info:");
            Console.WriteLine("ID: " + customer.GetId());
            Console.WriteLine("Name: " + customer.GetName());
            Console.WriteLine("Address: " + customer.GetAddress());
            Console.WriteLine("Phone: " + customer.GetPhone());
            Console.WriteLine();

        }
    }

}


