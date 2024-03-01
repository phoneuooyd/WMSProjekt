using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DataAccess/DatabaseInitializer.cs
using System;
using System.Data.SqlClient;
using WMS___Projekt.Models;
using System.Reflection;

namespace WMS___Projekt.DataAccess
{
    public class DatabaseInitializer
    {
        public static void InitializeDatabase(string serverName, string databaseName, string login, string password, bool isWindowsAuthentication)
        {
            string createDatabaseQuery = $"CREATE DATABASE {databaseName}";
            string connectionString = string.Empty;
            
            SqlConnection connection = new SqlConnection();

            if (isWindowsAuthentication)
            {
                connectionString = "Data Source=" + serverName + ";Initial Catalog=master;Integrated Security=True";
            }
            else
            {
                connectionString = "Data Source=" + serverName + ";Initial Catalog=master;User ID=" + login + ";Password=" + password;
            }
            using (connection)
            {
                try
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    SqlCommand createDatabaseCommand = new SqlCommand(createDatabaseQuery, connection);
                    createDatabaseCommand.ExecuteNonQuery();
                    Console.WriteLine($"Database '{databaseName}' created successfully.");
                    MessageBox.Show($"Database '{databaseName}' created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.ChangeDatabase(databaseName);


                    string createTableQuery = @"CREATE TABLE StoredCars (
                                                CarId INT PRIMARY KEY IDENTITY(1,1),
                                                Model NVARCHAR(100),
                                                Manufacturer NVARCHAR(100),
                                                Year INT,
                                                Price DECIMAL(18, 2),
                                                Amount INT,
                                                WarehouseSection NVARCHAR(100)
                                            )";

                    SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
                    createTableCommand.ExecuteNonQuery();

                    Console.WriteLine("Table 'StoredCars' created successfully.");
                    MessageBox.Show("Table 'StoredCars' created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    createTableQuery = @"CREATE TABLE Cars (
                                        CarId INT PRIMARY KEY IDENTITY(1,1),
                                        Model NVARCHAR(100),
                                        Manufacturer NVARCHAR(100),
                                        Year INT,
                                        Price DECIMAL(18, 2)
                                        )";

                    createTableCommand = new SqlCommand(createTableQuery, connection);
                    createTableCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating database '{databaseName}': {ex.Message}");
                    MessageBox.Show($"Error creating database '{databaseName}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void ConnectToDatabase(string databaseName, string login, string password, bool isWindowsAuthentication)
        {
            SqlConnection connection = new SqlConnection();
            string connectionString = string.Empty;
            try
            {
                if (isWindowsAuthentication)
                {
                    connectionString = $"Data Source={databaseName};Initial Catalog=AdventureWorks;Integrated Security=True";
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    connectionString = $"Data Source={databaseName};Initial Catalog=AdventureWorks;User ID={login};Password={password}";
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login Failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

