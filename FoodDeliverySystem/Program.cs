using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliverySystem.services;
using FoodDeliverySystem.modules;
using System.Windows.Forms;
using FoodDeliverySystem.views;


namespace FoodDeliverySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();   // Makes the app look modern
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Startform());
        }
    }

}