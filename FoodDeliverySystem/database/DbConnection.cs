using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.database
{
    public class DbConnection
    {
        private static string connectionString = "server=localhost;database=food_delivery_system;uid=root;pwd=;";
        private static MySqlConnection connection;


        public static MySqlConnection GetConnection()
        {
            if (connection == null || connection.State == System.Data.ConnectionState.Closed)
            {
                connection = new MySqlConnection(connectionString);
            }

            return connection;
        }
    }
}
