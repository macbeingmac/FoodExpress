using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliverySystem.modules;


namespace FoodDeliverySystem.services
{
    class DeliveryService

    {
        private List<Delivery> deliveries = new List<Delivery>();
        private int nextDeliveryId = 1;

        // Add a new delivery
        public void AddDelivery(int orderId, string deliveryPersonName, string status)
        {
            Delivery d = new Delivery(nextDeliveryId++, orderId, deliveryPersonName, status);
            deliveries.Add(d);
        }

        // View all deliveries
        public void ViewDeliveries()
        {
            if (deliveries.Count == 0)
            {
                Console.WriteLine("No deliveries found.");
                return;
            }

            Console.WriteLine("\nList of Deliveries:");
            foreach (Delivery d in deliveries)
            {
                Console.WriteLine($"Delivery ID: {d.GetDeliveryId()}, Order ID: {d.GetOrderId()}, " +
                                  $"Person: {d.GetDeliveryPersonName()}, Status: {d.GetStatus()}");
            }
        }

        // Update delivery status
        public void UpdateDeliveryStatus(int deliveryId, string newStatus)
        {
            foreach (Delivery d in deliveries)
            {
                if (d.GetDeliveryId() == deliveryId)
                {
                    d.SetStatus(newStatus);
                    return;
                }
            }

            Console.WriteLine("Delivery not found.");
        }

        // Assign a new delivery staff
        public void AssignDeliveryStaff(int deliveryId, string newStaffName)
        {
            foreach (Delivery d in deliveries)
            {
                if (d.GetDeliveryId() == deliveryId)
                {
                    d.SetDeliveryPersonName(newStaffName);
                    return;
                }
            }

            Console.WriteLine("Delivery not found.");
        }

        // Delete a delivery
        public void DeleteDelivery(int deliveryId)
        {
            Delivery toRemove = null;

            foreach (Delivery d in deliveries)
            {
                if (d.GetDeliveryId() == deliveryId)
                {
                    toRemove = d;
                    break;
                }
            }

            if (toRemove != null)
            {
                deliveries.Remove(toRemove);
            }
            else
            {
                Console.WriteLine("Delivery not found.");
            }
        }
    }
}
