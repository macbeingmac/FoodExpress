using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.modules
{
    class DeliveryStaff : Person
    {
        private string vehicle;

        // Constructor
        public DeliveryStaff(int id, string name, string password, string vehicle)
            : base(id, name, password)
        {
            this.vehicle = vehicle;
        }

        // Getter and Setter for Vehicle
        public string GetVehicle()
        {
            return vehicle;
        }

        public void SetVehicle(string value)
        {
            vehicle = value;
        }
    }
}
