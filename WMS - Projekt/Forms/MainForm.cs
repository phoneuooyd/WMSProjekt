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
        SqlConnection connection;
        string? databaseName = string.Empty;
        bool isDatagridViewLoaded = false;
        public List<Car> cars { get; set; }

        public MainForm()
        {
            InitializeComponent();
            this.databaseName = DatabaseInitializer.ReturnCurrentDatabaseName();
            this.connection = new SqlConnection(DatabaseInitializer.ReturnConnectionString());
        }
        public MainForm(string databaseName, SqlConnection connection)
        {
            InitializeComponent();
            this.databaseName = databaseName;
            this.connection = connection;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cars;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void loadDatagrid_Click(object sender, EventArgs e)
        {

        }
    }
}
