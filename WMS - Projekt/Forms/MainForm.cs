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
using WMS___Projekt.Utillities;

namespace WMS___Projekt.Forms
{
    public partial class MainForm : Form
    {
        SqlConnection connection = new SqlConnection();
        string? databaseName = string.Empty;
        public MainForm()
        {
            InitializeComponent();
            databaseName = DatabaseInitializer.ReturnCurrentDatabaseName();
            connection = new SqlConnection(DatabaseInitializer.ReturnConnectionString());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          //  dataGridView1.DataSource = DataQueryService.GetAllData(connection, databaseName);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
