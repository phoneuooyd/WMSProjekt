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

        public AddElementForm()
        {
            InitializeComponent();

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
                Manufacturer = carManufacturer,
                Model = carModel,
                Year = carProductionYear,
                Price = carPrice,
                Color = color
            };

            _repository.Add(car);

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
