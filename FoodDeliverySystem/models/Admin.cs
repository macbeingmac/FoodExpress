using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.modules
{
    class Admin : Person
    {
        private string password;

        // Constructor
        public Admin(int id, string name, string password): base(id, name)
        {
            this.password = password;
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
