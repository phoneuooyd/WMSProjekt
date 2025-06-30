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
using WMS___Projekt.Utillities;

namespace WMS___Projekt.Forms
{
    public partial class MainForm : Form
    {
        public DataTable dataTable;
        private readonly ICarRepository _repository = new CarRepository();
        public MainForm()
        {
            InitializeComponent();
            dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
        }
        private string GetSelectedRow()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewCell carIdCell = dataGridView1.Rows[rowIndex].Cells["CarId"];

                if (carIdCell.Value != null)
                {
                    string carId = carIdCell.Value.ToString();
                    return carId;
                }
            }
            return string.Empty;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void loadDatagrid_Click(object sender, EventArgs e)
        {
            dataTable = _repository.GetAll();
            dataGridView1.DataSource = dataTable;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FormManager.ShowForm(new AddElementForm());
            dataGridView1.DataSource = dataTable;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string carId = GetSelectedRow();
            if (!string.IsNullOrEmpty(carId) && int.TryParse(carId, out int id))
            {
                DataRow row = dataTable.Rows
                    .Cast<DataRow>()
                    .FirstOrDefault(r => r.Field<int>("CarId") == id);
                if (row != null)
                {
                    var car = new Car
                    {
                        CarId = id,
                        Manufacturer = row.Field<string>("Manufacturer"),
                        Model = row.Field<string>("Model"),
                        Year = row.Field<int>("Year"),
                        Price = row.Field<decimal>("Price"),
                        Color = row.Field<string>("Color")
                    };

                    FormManager.ShowForm(new AddElementForm(car));
                }
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string carId = GetSelectedRow();
            if (!string.IsNullOrEmpty(carId))
            {
                if (int.TryParse(carId, out int id))
                {
                    _repository.Delete(id);
                    loadDatagrid_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Invalid Car ID format: " + carId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FormManager.ShowForm(new NewDatabaseForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormManager.ShowForm(new LoginForm());
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            FormManager.CloseAllForms();
            this.Close();

        }
    }
}
