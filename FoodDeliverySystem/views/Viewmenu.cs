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


namespace FoodDeliverySystem.views
{
    public partial class Viewmenu: Form
    {
        private Restaurant loggedInRestaurant;

        public Viewmenu(Restaurant restaurant)
        {
            InitializeComponent();
            loggedInRestaurant = restaurant;
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id, name, price, availability FROM menuitems WHERE restaurantId = @restaurantId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@restaurantId", loggedInRestaurant.GetId());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvgrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu items: " + ex.Message);
            }
        }

        private void dgvgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
