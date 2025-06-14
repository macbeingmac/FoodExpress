using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliverySystem.database;
using System.Windows.Forms;

namespace FoodDeliverySystem.views
{
    public partial class Managerestaurantsform: Form
    {
        public Managerestaurantsform()
        {
            InitializeComponent();
            LoadRestaurants();
        }

        private void LoadRestaurants()
        {
            string query = "SELECT id AS 'ID', name AS 'Name', address AS 'Address' FROM restaurant";

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvgrid.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading restaurants: " + ex.Message);
                }
            }
        }

        private void Managerestaurantsform_Load(object sender, EventArgs e)
        {

        }

        private void lblAddaRestaurant_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtRestaurantName.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in both name and address.");
                return;
            }

            string query = "INSERT INTO restaurant (name, address) VALUES (@name, @address)";

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Restaurant added successfully!");
                    LoadRestaurants(); // Refresh table
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding restaurant: " + ex.Message);
                }
            }
        }
    }
}
