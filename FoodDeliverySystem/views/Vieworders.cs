using FoodDeliverySystem.modules;
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
    public partial class Vieworders: Form
    {
        private Restaurant loggedInRestaurant;
        public Vieworders(Restaurant restaurant)
        {
            InitializeComponent();
            loggedInRestaurant = restaurant;
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id, customerId, menuId, quantity, status FROM orders WHERE restaurantId = @restaurantId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@restaurantId", loggedInRestaurant.GetId());


                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvgrid1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }


        private void dgvgrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
