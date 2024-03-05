using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS___Projekt.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string? Model { get; set; }
        public string? Manufacturer { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; } = 0;
        public string? Color { get; set; }   = string.Empty;

        public Car(int carId,string manufacturer, string model, int year, decimal price, string color)
        {
            CarId = carId;
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
            Price = price;
            Color = color;
        }

    }

}
