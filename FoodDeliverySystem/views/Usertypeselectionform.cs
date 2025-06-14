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
    public partial class Usertypeselectionform: Form
    {
        public Usertypeselectionform()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminRegisterForm adminForm = new AdminRegisterForm();
            adminForm.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customerregisterform custForm = new Customerregisterform();
            custForm.Show();
            this.Hide();
        }

        private void btnDeliveryStaff_Click(object sender, EventArgs e)
        {
            Deliveryregisterform staffForm = new Deliveryregisterform();
            staffForm.Show();
            this.Hide();

        }

        private void btnRestaurant_Click(object sender, EventArgs e)
        {
            
            Restaurantregisterform restForm = new Restaurantregisterform();
            restForm.Show();
            this.Hide();
        }
    }
}
