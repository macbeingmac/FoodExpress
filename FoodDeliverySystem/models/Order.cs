using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.modules
{
    class Order
    {
        private int id;
        private Customer customer;
        private Restaurant restaurant;
        private List<MenuItem> items = new List<MenuItem>();
        private string status; // e.g., "Pending", "Preparing", "Out for Delivery", "Delivered"
        private DateTime orderDate;

        public Order(int id, Customer customer, Restaurant restaurant, List<MenuItem> items)
        {
            SetId(id);
            SetCustomer(customer);
            SetRestaurant(restaurant);
            SetItems(items);
            SetStatus("Pending"); // default status
            SetOrderDate(DateTime.Now);
        }

        // Getters & Setters
        public int GetId() => id;
        public void SetId(int value) => id = value;

        public Customer GetCustomer() => customer;
        public void SetCustomer(Customer value) => customer = value;

        public Restaurant GetRestaurant() => restaurant;
        public void SetRestaurant(Restaurant value) => restaurant = value;

        public List<MenuItem> GetItems() => items;
        public void SetItems(List<MenuItem> value) => items = value;

        public string GetStatus() => status;
        public void SetStatus(string value) => status = value;

        public DateTime GetOrderDate() => orderDate;
        public void SetOrderDate(DateTime value) => orderDate = value;
    }
}
