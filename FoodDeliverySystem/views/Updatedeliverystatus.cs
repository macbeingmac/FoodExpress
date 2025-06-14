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
using FoodDeliverySystem.database;
using System.Windows.Forms;

namespace FoodDeliverySystem.views
{
    public partial class Updatedeliverystatus: Form
    {
        private DeliveryStaff staff;

        public Updatedeliverystatus(DeliveryStaff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string deliveryIdText = txtdeliveryid.Text.Trim();
            string newStatus = txtstatus.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(deliveryIdText) || string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Please enter both Delivery ID and New Status.");
                return;
            }

            if (!int.TryParse(deliveryIdText, out int deliveryId))
            {
                MessageBox.Show("Delivery ID must be a valid number.");
                return;
            }

            // Allowed statuses
            string[] validStatuses = { "Pending", "Out for Delivery", "Delivered" };
            if (Array.IndexOf(validStatuses, newStatus) == -1)
            {
                MessageBox.Show("Invalid status. Use: Pending, Out for Delivery, or Delivered.");
                return;
            }

            // Update database
            string query = "UPDATE delivery SET status = @status WHERE delivery_id = @id AND delivery_person_name = @name";

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@id", deliveryId);
                    cmd.Parameters.AddWithValue("@name", staff.GetName());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Delivery status updated successfully!");
                        txtdeliveryid.Clear();
                        txtstatus.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Delivery not found or you're not authorized to update it.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating delivery status: " + ex.Message);
                }
            }
        }
    }
    
}
