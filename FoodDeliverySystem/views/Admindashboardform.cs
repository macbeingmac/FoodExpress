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
    public partial class Admindashboardform: Form
    {
        public Admindashboardform()
        {
            InitializeComponent();
        }

        private void btnManageRestaurants_Click(object sender, EventArgs e)
        {
            Managerestaurantsform form = new Managerestaurantsform();
            form.ShowDialog(); // Open restaurant management
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            Menumanagementform form = new Menumanagementform();
            form.ShowDialog(); // Open menu management
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            Manageorders form = new Manageorders();
            form.ShowDialog(); // (Create this form if needed)
        }

        private void btnManageDeliveries_Click(object sender, EventArgs e)
        {
            Managedeliveries form = new Managedeliveries();
            form.ShowDialog();
        }

        private void btnManageReviews_Click(object sender, EventArgs e)
        {
            Managereviews form = new Managereviews(); // (Create if needed)
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
