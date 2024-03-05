using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS___Projekt.DataAccess
{
    internal class DataQueryService
    {
        private SqlConnection connection;
        private DataTable dataTable;
        public DataTable GetAllData(SqlConnection connection, DataTable dataTable)
        {
            this.connection = connection;
            this.dataTable = dataTable;

            try
            {
                connection.Open(); // Open the connection
                string query = $"SELECT * FROM Car"; // Replace TableName with your table name
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
                Console.WriteLine("Data retrieved successfully.");
                Console.WriteLine(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving data: {ex.Message}");
                Console.WriteLine(ex.InnerException);
                // Handle the exception as needed
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Close the connection if it's open
                }
            }

            return dataTable;
        }
    }
}

