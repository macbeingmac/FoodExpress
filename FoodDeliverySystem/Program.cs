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


            using System;
            using FoodDeliverySystem.modules;
            using FoodDeliverySystem.services;

namespace FoodDeliverySystem
    {
        class Program
        {
            static void Main(string[] args)
            {
                DeliveryService deliveryService = new DeliveryService();

                // 1. Add deliveries
                deliveryService.AddDelivery(101, "John", "Pending");
                deliveryService.AddDelivery(102, "Emma", "Out for Delivery");
                deliveryService.AddDelivery(103, "Leo", "Pending");

                // 2. Show all deliveries
                Console.WriteLine(" All Deliveries:");
                deliveryService.ShowDeliveries();

                // 3. Update delivery status
                Console.WriteLine("\n Updating status of Delivery ID 1 to Delivered...");
                deliveryService.ChangeStatus(1, "Delivered");

                // 4. Change delivery staff
                Console.WriteLine(" Changing delivery person of Delivery ID 2 to Sarah...");
                deliveryService.ChangeDeliveryPerson(2, "Sarah");

                // 5. Delete a delivery
                Console.WriteLine(" Deleting Delivery ID 3...");
                deliveryService.RemoveDelivery(3);

                // 6. Show final list
                Console.WriteLine("\n Final Deliveries:");
                deliveryService.ShowDeliveries();

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }

}
    }
}
