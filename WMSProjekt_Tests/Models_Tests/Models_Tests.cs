using Xunit;
using WMS___Projekt.DataAccess;
using WMS___Projekt.Models;
namespace WMSProjekt_Tests.Models_Test
{
    public class WMSProjekt_Tests
    {
        [Fact]
        public void Car_Constructor_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            int carId = 1;
            string manufacturer = "Mercedes";
            string model = "SLK";
            int year = 2007;
            decimal price = 200000;
            string color = "Blue";

            // Act
            Car car = new Car(carId, manufacturer, model, year, price, color);

            // Assert

            Assert.Equal(carId, car.CarId);
            Assert.Equal(manufacturer, car.Manufacturer);
            Assert.Equal(model, car.Model);
            Assert.Equal(year, car.Year);
            Assert.Equal(price, car.Price);
            Assert.Equal(color, car.Color);


            Assert.IsType<int>(car.CarId);
            Assert.IsType<string>(car.Manufacturer);
            Assert.IsType<string>(car.Model);
            Assert.IsType<int>(car.Year);
            Assert.IsType<decimal>(car.Price);
            Assert.IsType<string>(car.Color);
        }
    }
}