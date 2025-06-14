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
    public partial class Customerregisterform : Form
    {
        public Customerregisterform()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string name = txtName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string phone = txtPhonenumber.Text.Trim();
            string password = txtCreatePassword.Text;

            if (name == "" || address == "" || phone == "" || password == "")
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            try
            {
                MySqlConnection conn = DbConnection.GetConnection();
                conn.Open();

                string sql = "INSERT INTO customer (name, address, phone, password) VALUES (@name, @address, @phone, @password)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@password", password);

                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Customer registered successfully!");
                    Loginform loginForm = new Loginform();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Registration failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

