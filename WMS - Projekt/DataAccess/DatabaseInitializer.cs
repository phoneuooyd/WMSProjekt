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
using Microsoft.Identity.Client;
using System.Security.Authentication;

namespace WMS___Projekt.DataAccess
{
    public class DatabaseInitializer
    {
        public static string? CurrentDatabaseName;
        public static string? CurrentConnectionString;
        public static string ReturnCurrentDatabaseName()
        {
            return CurrentDatabaseName;
        }
        public static string ReturnConnectionString()
        {
            return CurrentConnectionString;
        }
        public static bool InitializeDatabase(string serverName, string databaseName, string login, string password, bool isWindowsAuthentication)
        {
            string createDatabaseQuery = $"CREATE DATABASE {databaseName}";
            string connectionString = string.Empty;
            CurrentDatabaseName = databaseName;
            
            SqlConnection connection = new SqlConnection();

            if (isWindowsAuthentication)
            {
                connectionString = "Data Source=" + serverName + ";Initial Catalog=master;Integrated Security=True";
                CurrentConnectionString = connectionString;
            }
            else
            {
                connectionString = "Data Source=" + serverName + ";Initial Catalog=master;User ID=" + login + ";Password=" + password;
                CurrentConnectionString = connectionString;
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


                    string createTableQuery = @"CREATE TABLE Cars (
                                        CarId INT PRIMARY KEY IDENTITY(1,1),
                                        Model NVARCHAR(100),
                                        Manufacturer NVARCHAR(100),
                                        Year INT,
                                        Price DECIMAL(18, 2)
                                        )";

                    SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
                    createTableCommand.ExecuteNonQuery();

                    Console.WriteLine("Table 'Cars' created successfully.");
                    MessageBox.Show("Table 'StoredCars' created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating database '{databaseName}': {ex.Message}");
                    MessageBox.Show($"Error creating database '{databaseName}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
        }

        public static bool ConnectToDatabase(string serverName, string databaseName, string login, string password, bool isWindowsAuthentication)
        {
            SqlConnection connection = new SqlConnection();
            string connectionString = string.Empty;
            CurrentDatabaseName = databaseName;
            try
            {
                if (isWindowsAuthentication)
                {
                    connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    CurrentConnectionString = connectionString;
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    connectionString = $"Data Source={serverName};Initial Catalog={databaseName};User ID={login};Password={password}";
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    CurrentConnectionString = connectionString;
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login Failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            
        }


    }
    
}

