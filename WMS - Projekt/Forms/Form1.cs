using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS___Projekt.Models;


namespace WMS___Projekt.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
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

            MainForm.cars.Add(new Car(MainForm.cars.Count + 1, carManufacturer, carModel, carProductionYear, carPrice,  color));
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
