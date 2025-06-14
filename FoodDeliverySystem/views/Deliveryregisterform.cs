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
using FoodDeliverySystem.database;

namespace FoodDeliverySystem.views
{
    public partial class Deliveryregisterform: Form
    {
        public Deliveryregisterform()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string vehicle = txtVehicleType.Text.Trim();
            string password = txtCreatePassword.Text.Trim();

            if (name == "" || vehicle == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                MySqlConnection conn = DbConnection.GetConnection();
                conn.Open();

                string sql = "INSERT INTO deliverystaff (name, vehicle, password) VALUES (@name, @vehicle, @password)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@vehicle", vehicle);
                cmd.Parameters.AddWithValue("@password", password);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Delivery Staff registered successfully!");
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
    
    }
}
