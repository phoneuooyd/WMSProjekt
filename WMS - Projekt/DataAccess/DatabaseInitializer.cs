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
        public static string currentDatabaseName;
        public static string currentServerName;
        public static string currentConnectionString;
        public static bool isWindowsAuth;
        public static string currentLogin;    
        public static string currentPassword;
        
        public static string ReturnCurrentDatabaseName()
        {
            return currentDatabaseName;
        }
        public static string ReturnConnectionString()
        {
            return currentConnectionString;
        }
        public static string ReturnServerName()
        {
            return currentServerName;
        }
        public static bool ReturnIsWindowsAuth()
        {
            return isWindowsAuth;
        }
        public static string ReturnLogin()
        {
            return currentLogin;
        }
        public static string ReturnPassword()
        {
            return currentPassword;
        }
        public static string CreateConnectionString()
        {
            string dbName = ReturnCurrentDatabaseName();
            string serverName = ReturnServerName();
            bool isWindowsAuth = ReturnIsWindowsAuth();
            string login = ReturnLogin();
            string password = ReturnPassword();
            
            if (isWindowsAuth)
            {
                return $"Data Source={serverName};Initial Catalog={dbName};Integrated Security=True";
            }
            else
            {
                return $"Data Source={serverName};Initial Catalog={dbName};User ID={login};Password={password}";
            }
        }
        public static bool InitializeDatabase(string serverName, string databaseName, string login, string password, bool isWindowsAuthentication)
        {
            string createDatabaseQuery = $"CREATE DATABASE {databaseName}";
            string connectionString = string.Empty;
            currentDatabaseName = databaseName;
            currentServerName = serverName;
            
            SqlConnection connection = new SqlConnection();

            if (isWindowsAuthentication)
            {
                connectionString = "Data Source=" + serverName + ";Initial Catalog=master;Integrated Security=True";
                currentConnectionString = connectionString;
                
            }
            else
            {
                connectionString = "Data Source=" + serverName + ";Initial Catalog=master;User ID=" + login + ";Password=" + password;
                currentConnectionString = connectionString;
                currentLogin = login;
                currentPassword = password;
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
                                        Price DECIMAL(18, 2),
                                        Color NVARCHAR(100)
                                        )";

                    SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
                    createTableCommand.ExecuteNonQuery();

                    Console.WriteLine("Table 'Cars' created successfully.");
                    MessageBox.Show("Table 'Cars' created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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
            currentDatabaseName = databaseName;
            try
            {
                if (isWindowsAuthentication)
                {
                    connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    currentConnectionString = connectionString;
                    isWindowsAuth = true;
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    connectionString = $"Data Source={serverName};Initial Catalog={databaseName};User ID={login};Password={password}";
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    currentConnectionString = connectionString;
                    currentLogin = login;
                    currentPassword = password;
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

