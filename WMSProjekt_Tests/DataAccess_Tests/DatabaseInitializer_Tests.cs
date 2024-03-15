using Xunit;
using WMS___Projekt.DataAccess;

namespace WMS___Projekt.Tests
{
    public class DatabaseInitializerTests
    {
        [Fact]
        public void CreateConnectionString_ShouldReturnCorrectConnectionString_WhenWindowsAuth()
        {
            // Arrange
            string serverName = "localhost";
            string databaseName = "TestDB";
            string expectedConnectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
            DatabaseInitializer.currentServerName = serverName;
            DatabaseInitializer.currentDatabaseName = databaseName;
            DatabaseInitializer.isWindowsAuth = true;

            // Act
            string connectionString = DatabaseInitializer.CreateConnectionString();

            // Assert
            Assert.Equal(expectedConnectionString, connectionString);
        }

        [Fact]
        public void CreateConnectionString_ShouldReturnCorrectConnectionString_WhenNotWindowsAuth()
        {
            // Arrange
            string serverName = "localhost";
            string databaseName = "TestDB";
            string login = "testuser";
            string password = "password";
            string expectedConnectionString = $"Data Source={serverName};Initial Catalog={databaseName};User ID={login};Password={password}";
            DatabaseInitializer.currentServerName = serverName;
            DatabaseInitializer.currentDatabaseName = databaseName;
            DatabaseInitializer.currentLogin = login;
            DatabaseInitializer.currentPassword = password;
            DatabaseInitializer.isWindowsAuth = false;

            // Act
            string connectionString = DatabaseInitializer.CreateConnectionString();

            // Assert
            Assert.Equal(expectedConnectionString, connectionString);
        }

    }
}
