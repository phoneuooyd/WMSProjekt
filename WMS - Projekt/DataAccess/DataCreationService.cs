using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WMS___Projekt.Forms;

namespace WMS___Projekt.DataAccess
{
    internal class DataCreationService
    {
        public static void CreateData(string carModel, string carManufacturer, int carProductionYear, decimal carPrice,string color)
        {
            string dbName = DatabaseInitializer.ReturnCurrentDatabaseName();
            string createTableQuery = @$"INSERT INTO {dbName}.dbo.Cars (Model, Manufacturer, Year, Price, Color) 
                                        VALUES ('{carModel}', '{carManufacturer}', {carProductionYear}, {carPrice}, '{color}');";
            string connectionString = DatabaseInitializer.currentConnectionString;
            Console.WriteLine(connectionString);
            SqlConnection connection = new SqlConnection(connectionString);
            Console.WriteLine(connection);
            using (connection)
            {
               try
               {
                   connection.Open();
                   SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
                   createTableCommand.ExecuteNonQuery();
                   Console.WriteLine("Object created successfully");
               }
               catch (Exception ex)
               {
                   Console.WriteLine($"Error creating object: {ex.Message}");
                   Console.WriteLine(ex.InnerException);
               }
               finally
               {
                   connection.Close();
               } 
            }
            
        }

        public static void DeleteData(int carId)
        {
            string dbName = DatabaseInitializer.ReturnCurrentDatabaseName();
            SqlConnection connection = new SqlConnection(DatabaseInitializer.currentConnectionString);
            string createTableQuery = @$"DELETE FROM {dbName}.dbo.Cars WHERE CarId = {carId};";
            
            using (connection)
            { 
                try
                {
                connection.Open();
                SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();
                Console.WriteLine($"Object deleted successfully.");
                }
                catch (Exception ex)
            {
                Console.WriteLine($"Error deleting object: {ex.Message}");
                Console.WriteLine(ex.InnerException);
            }
                finally
                {
                    connection.Close();
                }
            } 
        }
    }
}
