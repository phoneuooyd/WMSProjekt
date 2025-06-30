using System.Data.SqlClient;
using WMS___Projekt.DataAccess.Repositories;
using WMS___Projekt.Models;
using Xunit;

namespace WMS___Projekt.Tests
{
    public class CarRepositoryTests
    {
        [Fact]
        public void BuildInsertCommand_ShouldCreateCommandWithParameters()
        {
            // Arrange
            var repo = new CarRepository("Server=.;Database=Test;Trusted_Connection=True;", "Test");
            var connection = new SqlConnection();
            var car = new Car { Manufacturer = "Test", Model = "Model", Year = 2000, Price = 10, Color = "Red" };

            // Act
            var command = repo.BuildInsertCommand(connection, car);

            // Assert
            Assert.Equal(5, command.Parameters.Count);
            Assert.Equal(car.Model, command.Parameters["@Model"].Value);
            Assert.Equal(car.Manufacturer, command.Parameters["@Manufacturer"].Value);
            Assert.Equal(car.Year, command.Parameters["@Year"].Value);
            Assert.Equal(car.Price, command.Parameters["@Price"].Value);
            Assert.Equal(car.Color, command.Parameters["@Color"].Value);
        }
    }
}
