using System;
using FoodDeliverySystem.modules;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using FoodDeliverySystem.database;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.views
{
    public partial class Viewassigneddeliveries: Form
    {
        private DeliveryStaff staff;

        public Viewassigneddeliveries(DeliveryStaff staff)
        {
            InitializeComponent();
            this.staff = staff;
            LoadAssignedDeliveries(); // Load deliveries when form opens
        }

        private void LoadAssignedDeliveries()
        {
            string query = "SELECT delivery_id AS 'Delivery ID', order_id AS 'Order ID', status AS 'Status' FROM delivery WHERE delivery_person_name = @name";

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", staff.GetName());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvgrid1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading assigned deliveries: " + ex.Message);
                }
            }
        }


        private void dgvgrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
