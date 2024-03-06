using System;
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
        private Label label1;
        private Label label2;
        private Button loginButton;
        private Button cancelButton;
        private TextBox loginTextbox;
        private CheckBox isWindowsAuthenticationCheckbox;
        private Label serverNameLabel;
        private TextBox serverNameTextbox;
        private Label databaseNameLabel;
        private TextBox databaseNameTextbox;
        private TextBox passwordTextbox;
        private Label newDatabaseLabel;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void NewDatabaseLabel_Click(object sender, EventArgs e)
        {
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
            string serverName = serverNameTextbox.Text;
            string databaseName = databaseNameTextbox.Text;
            bool isWindowsAuthentication = isWindowsAuthenticationCheckbox.Checked;

            if(DatabaseInitializer.ConnectToDatabase(serverName, databaseName, login, password, isWindowsAuthentication))
            {
                this.Close();
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
            Console.WriteLine("onFormCLose in LoginForm.cs");
            this.Close();
        }
        private void OnFormHide(object sender, FormClosedEventArgs e)
        {
            FormManager.CloseAllForms();
            Console.WriteLine("onFormHide in LoginForm.cs");
            this.Close();
        }
    }
}
