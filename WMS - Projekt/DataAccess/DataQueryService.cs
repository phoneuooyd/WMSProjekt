using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS___Projekt.DataAccess
{
    internal class DataQueryService
    {

        public DataQueryService() { }
        public static SqlCommand GetAllData(SqlConnection connection, string databaseName)
        {
            string query = @$"SELECT * FROM {databaseName};";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            Console.WriteLine("Data retrieved successfully.");

            return command;
        }
    }
}
