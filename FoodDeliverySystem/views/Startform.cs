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
    public partial class Startform : Form
    {
        public Startform()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Loginform loginForm = new Loginform(); 
            loginForm.Show();
            this.Hide();
        }


        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Usertypeselectionform selectionForm = new Usertypeselectionform(); 
            selectionForm.Show();
            this.Hide();
        }
    }
}
