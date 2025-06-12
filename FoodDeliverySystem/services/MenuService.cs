using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliverySystem.modules;

namespace FoodDeliverySystem.services
{
    class MenuService
    {
        private List<MenuItem> menuItems = new List<MenuItem>();
        private int nextId = 1;

        // Create a new menu item
        public void AddMenuItem(string name, double price, bool isAvailable = true)
        {
            MenuItem item = new MenuItem(nextId++, name, price, isAvailable);
            menuItems.Add(item);
        }

        // Read/view all menu items
        public void ViewMenuItems()
        {
            if (menuItems.Count == 0)
            {
                Console.WriteLine("No menu items found.");
                return;
            }

            Console.WriteLine("\nList of Menu Items:");
            foreach (MenuItem item in menuItems)
            {
                string status = item.GetAvailability() ? "Available" : "Unavailable";
                Console.WriteLine($"ID: {item.GetId()}, Name: {item.GetName()}, Price: {item.GetPrice()} LKR, Status: {status}");
            }
        }

        // Update menu item (by ID)
        public void UpdateMenuItem(int id, string newName, double newPrice, bool newAvailability)
        {
            foreach (MenuItem item in menuItems)
            {
                if (item.GetId() == id)
                {
                    item.SetName(newName);
                    item.SetPrice(newPrice);
                    item.SetAvailability(newAvailability);
                    return;
                }
            }

            Console.WriteLine("Menu item not found.");
        }

        // Delete a menu item (by ID)
        public void DeleteMenuItem(int id)
        {
            MenuItem toRemove = null;

            foreach (MenuItem item in menuItems)
            {
                if (item.GetId() == id)
                {
                    toRemove = item;
                    break;
                }
            }

            if (toRemove != null)
            {
                menuItems.Remove(toRemove);
            }
            else
            {
                Console.WriteLine("Menu item not found.");
            }
        }
    }
}
