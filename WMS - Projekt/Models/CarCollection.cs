using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS___Projekt.Models
{
    public class CarCollection
    {
        public Car CarObject { get; set; }
        public int Amount { get; set; }
        public string WarehouseSection { get; set; }

        // Constructor to initialize properties
        public CarCollection(Car carObject, int amount, string warehouseSection)
        {
            CarObject = carObject;
            Amount = amount;
            WarehouseSection = warehouseSection;
        }
    }
}
