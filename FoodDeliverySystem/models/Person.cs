using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.modules
{
    class Person
    {
        private int id;
        private string name;

        // Constructor
        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
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
    }
}
