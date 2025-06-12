using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliverySystem.modules;

namespace FoodDeliverySystem.services
{
    class OrderService
    {
        private List<Order> orders = new List<Order>();
        private int nextId = 1;

        // Create new order
        public void PlaceOrder(Customer customer, Restaurant restaurant, List<MenuItem> items)
        {
            Order order = new Order(nextId++, customer, restaurant, items);
            orders.Add(order);
        }

        // View all orders
        public void ViewOrders()
        {
            if (orders.Count == 0)
            {
                Console.WriteLine("No orders found.");
                return;
            }

            foreach (Order o in orders)
            {
                Console.WriteLine($"Order ID: {o.GetId()}, Customer: {o.GetCustomer().GetName()}, Restaurant: {o.GetRestaurant().GetName()}, Status: {o.GetStatus()}, Date: {o.GetOrderDate()}");
            }
        }

        // Update order status
        public void UpdateOrderStatus(int orderId, string newStatus)
        {
            foreach (Order o in orders)
            {
                if (o.GetId() == orderId)
                {
                    o.SetStatus(newStatus);
                    return;
                }
            }
            Console.WriteLine("Order not found.");
        }

        // Cancel order
        public void CancelOrder(int orderId)
        {
            Order toRemove = null;
            foreach (Order o in orders)
            {
                if (o.GetId() == orderId)
                {
                    toRemove = o;
                    break;
                }
            }

            if (toRemove != null)
            {
                orders.Remove(toRemove);
                Console.WriteLine("Order cancelled.");
            }
            else
            {
                Console.WriteLine("Order not found.");
            }
        }
    }
}
