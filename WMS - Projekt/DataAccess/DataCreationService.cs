using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS___Projekt.DataAccess
{
    internal class DataCreationService
    {
        public static void CreateData(string carModel, string carManufacturer, int carProductionYear, decimal carPrice, SqlConnection connection)
        {
            string createTableQuery = @$"INSERT INTO Cars (Model, Manufacturer, Year, Price) 
                                                  VALUES ('{carModel}', '{carManufacturer}', {carProductionYear}, {carPrice});";
            SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
            createTableCommand.ExecuteNonQuery();
            Console.WriteLine($"The {carManufacturer} {carModel} created successfully.");
        }

        public static void DeleteData(int carId, SqlConnection connection)
        {
            string createTableQuery = @$"DELETE FROM Cars WHERE CarId = {carId};";
            SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
            createTableCommand.ExecuteNonQuery();
            Console.WriteLine($"Object deleted successfully.");
        }

        public static void UpdateData(int carId, string carModel, string carManufacturer, int carProductionYear, decimal carPrice, SqlConnection connection)
        {
            string createTableQuery = @$"UPDATE Cars SET Model = '{carModel}', Manufacturer = '{carManufacturer}', Year = {carProductionYear}, Price = {carPrice} WHERE CarId = {carId};";
            SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
            createTableCommand.ExecuteNonQuery();
            Console.WriteLine("Object modified successfully");
        }
    }
}
