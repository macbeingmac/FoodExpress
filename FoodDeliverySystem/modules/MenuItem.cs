using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.modules
{
    class MenuItem 
    {
        private int id;
        private string name;
        private double price;
        private bool isAvailable;

        public MenuItem(int id, string name, double price, bool isAvailable = true)
        {
            SetId(id);
            SetName(name);
            SetPrice(price);
            SetAvailability(isAvailable);
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double value)
        {
            price = value;
        }

        public bool GetAvailability()
        {
            return isAvailable;
        }

        public void SetAvailability(bool value)
        {
            isAvailable = value;
        }
    }
}
