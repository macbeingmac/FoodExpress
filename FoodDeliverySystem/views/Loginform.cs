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
using FoodDeliverySystem.modules;
using FoodDeliverySystem.views;
using System.Xml.Linq;

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

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string[] userTypes = { "admin", "customer", "restaurant", "deliverystaff" };
            bool loginSuccess = false;
            string userType = "";

            foreach (var type in userTypes)
            {
                if (TryLogin(type, username, password, out userType))
                {
                    loginSuccess = true;
                    break;
                }
            }

            if (loginSuccess)
            {
                MessageBox.Show($"Login successful as {userType}!");

                Form dashboard = null;

                switch (userType)
                {
                    case "admin":
                        dashboard = new Admindashboardform(); break;
                    case "customer":
                        {
                            Customer customer = GetCustomerFromDB(username, password);
                            if (customer != null)
                            {
                                dashboard = new Customerdashboardform(customer);
                            }
                            break;
                        }

                    case "restaurant":
                        dashboard = new Restaurantdashboardform(); break;
                    case "deliverystaff":
                        DeliveryStaff staff = GetDeliveryStaffFromDB(username, password);
                        if (staff != null)
                        {
                            dashboard = new Deliverystaffdashboardform(staff);
                        }

                        break;
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


        private Customer GetCustomerFromDB(string username, string password)
        {
            string query = "SELECT * FROM customer WHERE name = @name AND password = @password";

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
                            int id = Convert.ToInt32(reader["id"]);
                            string name = reader["name"].ToString();
                            string pass = reader["password"].ToString();
                            string address = reader["address"].ToString();
                            string phone = reader["phone"].ToString();

                            return new Customer(id, name, pass, address, phone);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching customer: " + ex.Message);
                }
            }

            return null;
        }


        private DeliveryStaff GetDeliveryStaffFromDB(string username, string password)
        {
            string query = "SELECT * FROM deliverystaff WHERE name = @name AND password = @password";

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
                            int id = Convert.ToInt32(reader["id"]);
                            string name = reader["name"].ToString();
                            string pass = reader["password"].ToString();
                            string vehicle = reader["vehicle"].ToString();

                            return new DeliveryStaff(id, name, pass, vehicle);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching delivery staff: " + ex.Message);
                }
            }

            return null;
        }


    }
}
