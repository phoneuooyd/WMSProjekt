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
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeSqlConnection()
        {
            string connectionString = "Data Source=RESET2;Integrated Security=True;Initial Catalog=YourDatabaseName";
            connection = new SqlConnection(connectionString);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextbox.Text;
            string password = passwordTextbox.Text;
            string serverName = serverNameTextbox.Text;
            string databaseName = databaseNameTextbox.Text;
            bool isWindowsAuthentication = isWindowsAuthenticationCheckbox.Checked;

            DatabaseInitializer.ConnectToDatabase(databaseName, login, password, isWindowsAuthentication);
        }

        private void IsWindowsAuthenticationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (isWindowsAuthenticationCheckbox.Checked)
            {
                // Disable loginTextbox and passwordTextbox when checkbox is checked
                loginTextbox.Enabled = false;
                passwordTextbox.Enabled = false;
            }
            else
            {
                // Enable loginTextbox and passwordTextbox when checkbox is unchecked
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
    }
}
