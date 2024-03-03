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

        public DataQueryService() { }
        public static DataTable GetAllData(SqlConnection connection, string databaseName)
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open(); // Open the connection
                string query = $"SELECT * FROM [{databaseName}].[dbo].[Car]"; // Replace TableName with your table name
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
                Console.WriteLine("Data retrieved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving data: {ex.Message}");
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

