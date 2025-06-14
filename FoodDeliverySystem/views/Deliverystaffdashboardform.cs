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
    public partial class Deliverystaffdashboardform: Form
    {
        public Deliverystaffdashboardform()
        {
            InitializeComponent();
        }

        private void btnViewAssignedDeliveries_Click(object sender, EventArgs e)
        {
            Viewassigneddeliveries form = new Viewassigneddeliveries(loggedInStaff);
            form.ShowDialog();
        }
            

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateDeliveryStatus_Click_1(object sender, EventArgs e)
        {
            Updatedeliverystatus form = new Updatedeliverystatus(loggedInStaff);
            form.ShowDialog();
    }
}
