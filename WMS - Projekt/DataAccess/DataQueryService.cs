using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WMS___Projekt.DataAccess
{
    internal class DataQueryService
    {
        private SqlConnection connection;
        public DataTable GetAllData()
        {
            string connectionString = DatabaseInitializer.ReturnConnectionString();
            string dbName = DatabaseInitializer.ReturnCurrentDatabaseName();
            SqlConnection connection = new SqlConnection(connectionString);
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open(); 
                string query = $"SELECT * FROM {dbName}.dbo.Cars"; 
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
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return dataTable;
        }
    }
}

