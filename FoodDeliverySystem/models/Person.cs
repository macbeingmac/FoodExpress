using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.modules
{
    public class Person
    {
        private int id;
        private string name;
        private string password;

        // Constructor
        public Person(int id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }

        // Getter and Setter for ID
        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        // Getter and Setter for Name
        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        // Getter and Setter for Password
        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string value)
        {
            password = value;
        }
    }
}
