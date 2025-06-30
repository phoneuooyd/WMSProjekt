using System.Data;
using System.Data.SqlClient;
using WMS___Projekt.Models;

namespace WMS___Projekt.DataAccess.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly string _connectionString;
        private readonly string _dbName;

        public CarRepository()
            : this(DatabaseInitializer.ReturnConnectionString(), DatabaseInitializer.ReturnCurrentDatabaseName())
        {
        }

        public CarRepository(string connectionString, string dbName)
        {
            _connectionString = connectionString;
            _dbName = dbName;
        }

        internal SqlCommand BuildInsertCommand(SqlConnection connection, Car car)
        {
            var query = @$"INSERT INTO {_dbName}.dbo.Cars (Model, Manufacturer, Year, Price, Color)
                             VALUES (@Model, @Manufacturer, @Year, @Price, @Color);";
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Model", car.Model ?? string.Empty);
            command.Parameters.AddWithValue("@Manufacturer", car.Manufacturer ?? string.Empty);
            command.Parameters.AddWithValue("@Year", car.Year);
            command.Parameters.AddWithValue("@Price", car.Price);
            command.Parameters.AddWithValue("@Color", car.Color ?? string.Empty);
            return command;
        }

        internal SqlCommand BuildUpdateCommand(SqlConnection connection, Car car)
        {
            var query = @$"UPDATE {_dbName}.dbo.Cars SET Model=@Model, Manufacturer=@Manufacturer, Year=@Year, Price=@Price, Color=@Color WHERE CarId=@CarId";
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Model", car.Model ?? string.Empty);
            command.Parameters.AddWithValue("@Manufacturer", car.Manufacturer ?? string.Empty);
            command.Parameters.AddWithValue("@Year", car.Year);
            command.Parameters.AddWithValue("@Price", car.Price);
            command.Parameters.AddWithValue("@Color", car.Color ?? string.Empty);
            command.Parameters.AddWithValue("@CarId", car.CarId);
            return command;
        }

        public void Add(Car car)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = BuildInsertCommand(connection, car);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Update(Car car)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = BuildUpdateCommand(connection, car);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Delete(int carId)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @$"DELETE FROM {_dbName}.dbo.Cars WHERE CarId = @CarId";
            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CarId", carId);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public DataTable GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @$"SELECT * FROM {_dbName}.dbo.Cars";
            using var command = new SqlCommand(query, connection);
            var dataTable = new DataTable();
            connection.Open();
            using var reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
        }
    }
}
