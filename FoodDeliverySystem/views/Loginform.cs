using FoodDeliverySystem.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FoodDeliverySystem.database;

namespace FoodDeliverySystem.views
{
    public partial class Loginform: Form
    {
        public Loginform()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Check each user table
            if (TryLogin("admin", username, password, out string userType))
            {
                MessageBox.Show($"Login successful as {userType}!");

                // Open the correct dashboard form
                Form dashboard = null;

                switch (userType)
                {
                    case "admin":
                        dashboard = new Admindashboardform(); break;
                    case "customer":
                        dashboard = new CustomerDashboardForm(); break;
                    case "restaurant":
                        dashboard = new RestaurantDashboardForm(); break;
                    case "deliverystaff":
                        dashboard = new DeliveryStaffDashboardForm(); break;
                }

                if (dashboard != null)
                {
                    this.Hide();
                    dashboard.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool TryLogin(string userType, string username, string password, out string matchedType)
        {
            matchedType = "";

            string table = userType.ToLower();
            string query = $"SELECT * FROM {table} WHERE name = @name AND password = @password";

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            matchedType = userType;
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during login: " + ex.Message);
                }
            }

            return false;
        }
    }
}
