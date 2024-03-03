
namespace WMS___Projekt.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            loginButton = new Button();
            cancelButton = new Button();
            loginTextbox = new TextBox();
            passwordTextbox = new TextBox();
            isWindowsAuthenticationCheckbox = new CheckBox();
            serverNameLabel = new Label();
            serverNameTextbox = new TextBox();
            databaseNameLabel = new Label();
            databaseNameTextbox = new TextBox();
            newDatabaseLabel = new Label();
            createNewDatabaseButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 85);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 127);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += Label2_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(190, 216);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(113, 23);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(309, 216);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(129, 23);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // loginTextbox
            // 
            loginTextbox.Location = new Point(190, 82);
            loginTextbox.Name = "loginTextbox";
            loginTextbox.Size = new Size(248, 23);
            loginTextbox.TabIndex = 4;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(190, 124);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.Size = new Size(248, 23);
            passwordTextbox.TabIndex = 5;
            // 
            // isWindowsAuthenticationCheckbox
            // 
            isWindowsAuthenticationCheckbox.AutoSize = true;
            isWindowsAuthenticationCheckbox.Location = new Point(192, 191);
            isWindowsAuthenticationCheckbox.Name = "isWindowsAuthenticationCheckbox";
            isWindowsAuthenticationCheckbox.Size = new Size(205, 19);
            isWindowsAuthenticationCheckbox.TabIndex = 6;
            isWindowsAuthenticationCheckbox.Text = "Authenticate with Windows Login";
            isWindowsAuthenticationCheckbox.UseVisualStyleBackColor = true;
            isWindowsAuthenticationCheckbox.CheckedChanged += IsWindowsAuthenticationCheckbox_CheckedChanged;
            // 
            // serverNameLabel
            // 
            serverNameLabel.AutoSize = true;
            serverNameLabel.Location = new Point(92, 41);
            serverNameLabel.Name = "serverNameLabel";
            serverNameLabel.Size = new Size(72, 15);
            serverNameLabel.TabIndex = 7;
            serverNameLabel.Text = "Server name";
            // 
            // serverNameTextbox
            // 
            serverNameTextbox.Location = new Point(190, 38);
            serverNameTextbox.Name = "serverNameTextbox";
            serverNameTextbox.Size = new Size(248, 23);
            serverNameTextbox.TabIndex = 8;
            // 
            // databaseNameLabel
            // 
            databaseNameLabel.AutoSize = true;
            databaseNameLabel.Location = new Point(92, 165);
            databaseNameLabel.Name = "databaseNameLabel";
            databaseNameLabel.Size = new Size(88, 15);
            databaseNameLabel.TabIndex = 9;
            databaseNameLabel.Text = "Database name";
            databaseNameLabel.Click += Label3_Click;
            // 
            // databaseNameTextbox
            // 
            databaseNameTextbox.Location = new Point(190, 162);
            databaseNameTextbox.Name = "databaseNameTextbox";
            databaseNameTextbox.Size = new Size(248, 23);
            databaseNameTextbox.TabIndex = 10;
            // 
            // newDatabaseLabel
            // 
            newDatabaseLabel.AutoSize = true;
            newDatabaseLabel.Location = new Point(32, 263);
            newDatabaseLabel.Name = "newDatabaseLabel";
            newDatabaseLabel.Size = new Size(148, 15);
            newDatabaseLabel.TabIndex = 11;
            newDatabaseLabel.Text = "No database? No problem!";
            // 
            // createNewDatabaseButton
            // 
            createNewDatabaseButton.Location = new Point(190, 259);
            createNewDatabaseButton.Name = "createNewDatabaseButton";
            createNewDatabaseButton.Size = new Size(248, 23);
            createNewDatabaseButton.TabIndex = 12;
            createNewDatabaseButton.Text = "Create new database";
            createNewDatabaseButton.UseVisualStyleBackColor = true;
            createNewDatabaseButton.Click += NewDatabaseLabel_Click;
            // 
            // LoginForm
            // 
            ClientSize = new Size(579, 294);
            Controls.Add(createNewDatabaseButton);
            Controls.Add(newDatabaseLabel);
            Controls.Add(databaseNameTextbox);
            Controls.Add(databaseNameLabel);
            Controls.Add(serverNameTextbox);
            Controls.Add(serverNameLabel);
            Controls.Add(isWindowsAuthenticationCheckbox);
            Controls.Add(passwordTextbox);
            Controls.Add(loginTextbox);
            Controls.Add(cancelButton);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button createNewDatabaseButton;
    }
}