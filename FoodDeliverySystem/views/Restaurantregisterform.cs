using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FoodDeliverySystem.database;

namespace FoodDeliverySystem.views
{
    public partial class Restaurantregisterform: Form
    {
        public Restaurantregisterform()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtRestaurantName.Text.Trim();
            string address = txtRestaurantAddress.Text.Trim();
            string password = txtCreatepassword.Text.Trim();

            if (name == "" || address == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                MySqlConnection conn = DbConnection.GetConnection();
                conn.Open();

                string sql = "INSERT INTO restaurant (name, address, password) VALUES (@name, @address, @password)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@password", password);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Registered successfully!");
                    this.Hide();
                    Loginform login = new Loginform();
                    login.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration failed.");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtRestaurantName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
