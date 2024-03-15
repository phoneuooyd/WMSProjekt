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
using WMS___Projekt.DataAccess;
using WMS___Projekt.Models;


namespace WMS___Projekt.Forms
{
    public partial class AddElementForm : Form
    {
        DataQueryService dataQueryService = new DataQueryService();
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

            DataCreationService.CreateData(carModel, carManufacturer, carProductionYear, carPrice, color);

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
