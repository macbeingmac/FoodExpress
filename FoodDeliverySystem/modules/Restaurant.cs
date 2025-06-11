using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.modules
{
    class Restaurant
    {
        private int id;
        private string name;
        private string address;

        // Constructor
        public Restaurant(int id, string name, string address)
        {
            SetId(id);
            SetName(name);
            SetAddress(address);
        }

        // ID Getter & Setter
        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        // Name Getter & Setter
        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        // Address Getter & Setter
        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string value)
        {
            address = value;
        }
    }
}
