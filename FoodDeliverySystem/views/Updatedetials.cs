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
using MySql.Data.MySqlClient;

namespace FoodDeliverySystem.views
{
    public partial class Updatedetials: Form
    {
        private int restaurantId;

        public Updatedetials(int id)
        {
            InitializeComponent();
            restaurantId = id;
            LoadRestaurantDetails();
        }

        private void LoadRestaurantDetails()
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT name, address FROM restaurant WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", restaurantId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtname.Text = reader.GetString("name");
                            txtaddress1.Text = reader.GetString("address");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading details: " + ex.Message);
            }
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string address = txtaddress1.Text.Trim();

            if (name == "" || address == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE restaurant SET name = @name, address = @address WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@id", restaurantId);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Details updated successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
