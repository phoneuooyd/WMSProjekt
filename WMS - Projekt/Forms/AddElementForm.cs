using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS___Projekt.DataAccess.Repositories;
using WMS___Projekt.Models;


namespace WMS___Projekt.Forms
{
    public partial class AddElementForm : Form
    {
        private readonly ICarRepository _repository = new CarRepository();
        private bool _isEdit = false;
        private int _carId;

        public AddElementForm()
        {
            InitializeComponent();

        }

        public AddElementForm(Car car) : this()
        {
            if (car != null)
            {
                _isEdit = true;
                _carId = car.CarId;
                makeTextbox.Text = car.Manufacturer;
                modelTextbox.Text = car.Model;
                yearTextbox.Text = car.Year.ToString();
                priceTextbox.Text = car.Price.ToString();
                colorTextbox.Text = car.Color;
                confirmButton.Text = "Update";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click_1(object sender, EventArgs e)
        {
            string carModel = modelTextbox.Text;
            string carManufacturer = makeTextbox.Text;
            int carProductionYear = int.Parse(yearTextbox.Text);
            decimal carPrice = decimal.Parse(priceTextbox.Text);
            string color = colorTextbox.Text;

            var car = new Car
            {
                CarId = _carId,
                Manufacturer = carManufacturer,
                Model = carModel,
                Year = carProductionYear,
                Price = carPrice,
                Color = color
            };

            if (_isEdit)
            {
                _repository.Update(car);
            }
            else
            {
                _repository.Add(car);
            }

            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm?.loadDatagrid_Click(sender, e);

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
