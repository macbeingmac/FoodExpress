using FoodDeliverySystem.modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliverySystem.views
{
    public partial class Customerdashboardform: Form
    {
        private Customer loggedInCustomer;

        public Customerdashboardform(Customer customer)
        {
            InitializeComponent();
            loggedInCustomer = customer;
        }

        private void btnBrowseRestaurants_Click(object sender, EventArgs e)
        {
            Browserestaurants form = new Browserestaurants();
            form.ShowDialog();
        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            Viewmenu form = new Viewmenu();
            form.ShowDialog();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
          
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLeaveaReview_Click(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
