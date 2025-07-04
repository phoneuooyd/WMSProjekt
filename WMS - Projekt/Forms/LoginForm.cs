﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using WMS___Projekt.DataAccess;
using WMS___Projekt.Utillities;

namespace WMS___Projekt.Forms
{
    public partial class LoginForm : Form
    {
        private SqlConnection connection;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void NewDatabaseLabel_Click(object sender, EventArgs e)
        {
            FormManager.CloseAllForms();
            FormManager.ShowForm(new NewDatabaseForm());
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextbox.Text;
            string password = passwordTextbox.Text;
            string serverName = serverNameComboBox.Text;
            string databaseName = databaseNameTextbox.Text;
            bool isWindowsAuthentication = isWindowsAuthenticationCheckbox.Checked;

            if(DatabaseInitializer.ConnectToDatabase(serverName, databaseName, login, password, isWindowsAuthentication))
            {
                this.Close();
                FormManager.CloseAllForms();
                FormManager.ShowForm(new MainForm());
            }
            else
            {
                MessageBox.Show("Connection failed. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void IsWindowsAuthenticationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (isWindowsAuthenticationCheckbox.Checked)
            {
                loginTextbox.Enabled = false;
                passwordTextbox.Enabled = false;
            }
            else
            {
                loginTextbox.Enabled = true;
                passwordTextbox.Enabled = true;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void serverNameComboBox_DropDown(object sender, EventArgs e)
        {
            if (serverNameComboBox.Items.Count == 0)
            {
                var servers = SqlServerSearch.GetAvailableServers();
                foreach (var s in servers)
                {
                    serverNameComboBox.Items.Add(s);
                }
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            FormManager.CloseAllForms();
            this.Close();
        }
    }
}
