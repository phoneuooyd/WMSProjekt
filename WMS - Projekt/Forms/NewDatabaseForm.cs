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
    public partial class NewDatabaseForm : Form
    {
        private SqlConnection connection;


        public NewDatabaseForm()
        {
            InitializeComponent();
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            string serverName = serverNameTextBox.Text;
            string databaseName = newDatabaseTextbox.Text;
            string login = serverLoginTextbox.Text;
            string password = serverPasswordTextbox.Text;
            bool isWindowsAuthentication = isWindowsAuthenticationCheckbox.Checked;

           DatabaseInitializer.InitializeDatabase(serverName, databaseName, login, password, isWindowsAuthentication);
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
