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
    public partial class Viewreviews: Form
    {
        private Restaurant loggedInRestaurant;

        public Viewreviews(Restaurant restaurant)
        {
            InitializeComponent();
            loggedInRestaurant = restaurant;
            LoadReviews();
        }

        private void LoadReviews()
        {
            try
            {
                using (var conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT reviewId, reviewerName, comment, rating FROM reviews WHERE restaurantId = @restaurantId";
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
                MessageBox.Show("Error loading reviews: " + ex.Message);
            }
        }


        private void dgvgrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
