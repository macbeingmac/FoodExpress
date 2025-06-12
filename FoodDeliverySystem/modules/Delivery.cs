using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.modules
{
    class Delivery
{
        // Fields (private to ensure encapsulation)
        private int deliveryId;
        private int orderId;
        private string deliveryPersonName;
        private string status;  // e.g., "Pending", "Out for Delivery", "Delivered"

        // Constructor
        public Delivery(int deliveryId, int orderId, string deliveryPersonName, string status)
        {
            this.deliveryId = deliveryId;
            this.orderId = orderId;
            this.deliveryPersonName = deliveryPersonName;
            SetStatus(status); // Use setter to apply validation
        }

        // Getter & Setter for Delivery ID
        public int GetDeliveryId()
        {
            return deliveryId;
        }

        public void SetDeliveryId(int value)
        {
            deliveryId = value;
        }

        // Getter & Setter for Order ID
        public int GetOrderId()
        {
            return orderId;
        }

        public void SetOrderId(int value)
        {
            orderId = value;
        }

        // Getter & Setter for Delivery Person Name
        public string GetDeliveryPersonName()
        {
            return deliveryPersonName;
        }

        public void SetDeliveryPersonName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                deliveryPersonName = name;
            }
            else
            {
                Console.WriteLine("Delivery person name cannot be empty.");
            }
        }

        // Getter & Setter for Status
        public string GetStatus()
        {
            return status;
        }

        public void SetStatus(string newStatus)
        {
            // Accept only valid delivery statuses
            if (newStatus == "Pending" || newStatus == "Out for Delivery" || newStatus == "Delivered")
            {
                status = newStatus;
            }
            else
            {
                Console.WriteLine("Invalid delivery status. Use: Pending, Out for Delivery, or Delivered.");
            }
        }
    }
}
