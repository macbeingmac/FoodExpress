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
            // Setup dummy customer and restaurant
            Customer customer = new Customer(1, "John Doe", "123 Street", "0781234567");
            Restaurant restaurant = new Restaurant(1, "Pizza Palace", "Downtown");

            // Dummy menu items
            MenuItem item1 = new MenuItem(1, "Cheese Pizza", 1500.0, true);
            MenuItem item2 = new MenuItem(2, "Veg Pizza", 1300.0, true);
            List<MenuItem> orderedItems = new List<MenuItem> { item1, item2s };

            // Create the OrderService
            OrderService orderService = new OrderService();

            // Place an order
            orderService.PlaceOrder(customer, restaurant, orderedItems);

            // View all orders
            orderService.ViewOrders();

            Console.ReadLine(); // Keep the console window open

        }
    }

}


