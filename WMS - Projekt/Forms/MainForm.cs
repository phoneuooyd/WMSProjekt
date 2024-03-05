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
using WMS___Projekt.Utillities;

namespace WMS___Projekt.Forms
{
    public partial class MainForm : Form
    {
        public static BindingList<Car> cars;

        public MainForm()
        {
            InitializeComponent();
            cars = new BindingList<Car>(GetDummyDataForCars());
            dataGridView1.DataSource = cars;
        }

        private BindingList<Car>? GetDummyDataForCars()
        {
            BindingList<Car> returVal = new BindingList<Car>();
            returVal.Add(new Car(1, "Mercedes", "SLK", 2007, 200000, "Blue"));
            returVal.Add(new Car(2, "Mercedes", "C63", 2015, 250000, "Red"));
            returVal.Add(new Car(3, "BMW", "M3", 2018, 300000, "White"));
            returVal.Add(new Car(4, "BMW", "M5", 2019, 350000, "Green"));

            return returVal;
        }
        private string GetSelectedRow()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Access the cell in the CarId column for the selected row
                DataGridViewCell carIdCell = dataGridView1.Rows[rowIndex].Cells["CarId"];

                // Check if the cell value is not null
                if (carIdCell.Value != null)
                {
                    // Get the value of the CarId cell
                    string carId = carIdCell.Value.ToString();
                    return carId;
                }
            }
            return string.Empty;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void loadDatagrid_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cars;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FormManager.ShowForm(new Form1());
            dataGridView1.DataSource = cars;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string carId = GetSelectedRow();
            if (!string.IsNullOrEmpty(carId))
            {
                if (int.TryParse(carId, out int id))
                {
                    Car carToRemove = cars.FirstOrDefault(x => x.CarId == id);
                    if (carToRemove != null)
                    {
                        cars.Remove(carToRemove);
                        // Refresh the DataGridView to reflect the changes
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = cars;
                    }
                    else
                    {
                        MessageBox.Show("Car with ID " + carId + " not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormManager.ShowForm(new LoginForm());
            this.Close();
        }
    }
}
