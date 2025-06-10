using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RestaurantService
    {
        private List<Restaurant> restaurants = new List<Restaurant>();
        private int nextId = 1;

        // Creating a restaurent
        public void AddRestaurant(string name, string address)
        {
            Restaurant r = new Restaurant(nextId++, name, address);
            restaurants.Add(r);
        }

        // To view/read restaurent
        public void ViewRestaurants()
        {
            if (restaurants.Count == 0)
            {
                Console.WriteLine("No restaurants found.");
                return;
            }

            Console.WriteLine("\nList of Restaurants:");
            foreach (Restaurant r in restaurants)
            {
                Console.WriteLine($"ID: {r.GetId()}, Name: {r.GetName()}, Address: {r.GetAddress()}");
            }
        }

        // Update restaurent
        public void UpdateRestaurant(int id, string newName, string newAddress)
        {
            foreach (Restaurant r in restaurants)
            {
                if (r.GetId() == id)
                {
                    r.SetName(newName);
                    r.SetAddress(newAddress);
                    return;
                }
            }

            Console.WriteLine("Restaurant not found.");
        }

        // Delete restaurent
        public void DeleteRestaurant(int id)
        {
            Restaurant toRemove = null;

            foreach (Restaurant r in restaurants)
            {
                if (r.GetId() == id)
                {
                    toRemove = r;
                    break;
                }
            }

            if (toRemove != null)
            {
                restaurants.Remove(toRemove);
            }
            else
            {
                Console.WriteLine("Restaurant not found.");
            }
        }
    }
}
