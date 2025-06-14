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
    public partial class Restaurantdashboardform: Form
    {
        private Restaurant loggedInRestaurant;
        public Restaurantdashboardform(Restaurant restaurant)
        {
            InitializeComponent();
            loggedInRestaurant = restaurant;
 
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            Updatedetails form = new Updatedetails(loggedInRestaurant);
            form.ShowDialog();
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            Menumanagementform form = new Menumanagementform(loggedInRestaurant);
            form.ShowDialog();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            Manageorders form = new Manageorders(loggedInRestaurant);
            form.ShowDialog();
        }

        private void btnViewReviews_Click(object sender, EventArgs e)
        {
            Managereviews form = new Managereviews(loggedInRestaurant);
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the dashboard and returns to login or previous screen
        }
    }
}
