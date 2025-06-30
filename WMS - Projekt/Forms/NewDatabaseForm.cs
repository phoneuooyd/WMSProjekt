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

            if (DatabaseInitializer.InitializeDatabase(serverName, databaseName, login, password, isWindowsAuthentication))
            {
                MessageBox.Show("Database created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FormManager.ShowForm(new LoginForm());
            }
            else
            {
                MessageBox.Show("Database creation failed. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void isWindowsAuthenticationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (isWindowsAuthenticationCheckbox.Checked)
            {
                serverLoginTextbox.Enabled = false;
                serverPasswordTextbox.Enabled = false;
            }
            else
            {
                serverLoginTextbox.Enabled = true;
                serverPasswordTextbox.Enabled = true;
            }
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

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
