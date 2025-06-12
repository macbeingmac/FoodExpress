using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliverySystem.services;

namespace FoodDeliverySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantService rs = new RestaurantService();

            rs.AddRestaurant("Burger Shack", "Main Street");
            rs.AddRestaurant("Pizza Palace", "Ocean Road");

            rs.ViewRestaurants();

            rs.UpdateRestaurant(1, "Burger Heaven", "Sunset Ave");

            rs.ViewRestaurants();

            rs.DeleteRestaurant(2);

            rs.ViewRestaurants();

            Console.ReadLine(); // Keep console open

        }
    }

}


