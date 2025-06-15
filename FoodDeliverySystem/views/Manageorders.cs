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
    public partial class Manageorders: Form
    {
        public Manageorders()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            string query = "SELECT * FROM orders";

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
                    MessageBox.Show("Error loading orders: " + ex.Message);
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtorderid.Text) || string.IsNullOrWhiteSpace(txtstatus.Text))
            {
                MessageBox.Show("Please enter Order ID and new Status.");
                return;
            }

            string query = "UPDATE orders SET status = @status WHERE order_id = @id";

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", txtstatus.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtorderid.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order status updated successfully.");
                        LoadOrders();
                    }
                    else
                    {
                        MessageBox.Show("No order found with that ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating order: " + ex.Message);
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtorder.Text))
            {
                MessageBox.Show("Please enter Order ID to delete.");
                return;
            }

            string query = "DELETE FROM orders WHERE order_id = @id";

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtorder.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order deleted successfully.");
                        LoadOrders();
                    }
                    else
                    {
                        MessageBox.Show("No order found with that ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting order: " + ex.Message);
                }
            }
        }
    }
    
}
