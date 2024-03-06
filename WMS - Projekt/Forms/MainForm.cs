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
        public DataTable dataTable;
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
            dataTable = new DataQueryService().GetAllData();
            dataGridView1.DataSource = dataTable;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FormManager.ShowForm(new Form1());
            dataGridView1.DataSource = dataTable;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string carId = GetSelectedRow();
            if (!string.IsNullOrEmpty(carId))
            {
                if (int.TryParse(carId, out int id))
                {
                   DataCreationService.DeleteData(id);
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
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormManager.ShowForm(new LoginForm());
            this.Close();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            FormManager.CloseAllForms();
            this.Close();

        }
    }
}
