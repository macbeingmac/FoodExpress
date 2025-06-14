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
    public partial class AdminRegisterForm: Form
    {
        public AdminRegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Get the values entered by the user
            string adminName = txtAdminName.Text.Trim();
            string password = txtAdminPassword.Text;
            string confirmPassword = txtConfirmpassword.Text;

            // Check if any field is empty
            if (adminName == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Now we try to connect to the database and save the new admin
            try
            {
                // Get the connection from DbConnection class
                MySqlConnection conn = DbConnection.GetConnection();
                conn.Open(); // Open the connection

                // Create the SQL command to insert the new admin
                string sql = "INSERT INTO admin (name, password) VALUES (@name, @password)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                // Add the actual values to the command
                cmd.Parameters.AddWithValue("@name", adminName);
                cmd.Parameters.AddWithValue("@password", password);

                // Execute the command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the insert was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Admin registered successfully!");
                    this.Close(); // Close the form after success
                }
                else
                {
                    MessageBox.Show("Something went wrong. Admin not registered.");
                }

                conn.Close(); // Close the connection
            }
            catch (Exception ex)
            {
                // If there's any error, show the message
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
