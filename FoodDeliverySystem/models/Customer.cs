using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.modules
{
    public class Customer: Person
    {
        private string address;
        private string phone;

        // Constructor
        public Customer(int id, string name, string password, string address, string phone) : base(id, name, password)
        {
            this.address = address;
            this.phone = phone;
        }

        // Getter and Setter for Address
        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string value)
        {
            address = value;
        }

        // Getter and Setter for Phone
        public string GetPhone()
        {
            return phone;
        }

        public void SetPhone(string value)
        {
            phone = value;
        }
    }
}
