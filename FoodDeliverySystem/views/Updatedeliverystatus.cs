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
    public partial class Updatedeliverystatus: Form
    {
        private DeliveryStaff staff;

        public Updatedeliverystatus(DeliveryStaff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }
    }
}
