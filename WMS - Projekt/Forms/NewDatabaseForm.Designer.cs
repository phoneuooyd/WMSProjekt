namespace WMS___Projekt.Forms
{
    partial class NewDatabaseForm
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
            serverNameComboBox = new ComboBox();
            newDatabaseTextbox = new TextBox();
            serverNameLabel = new Label();
            newDatabaseNameLabel = new Label();
            createButton = new Button();
            cancelButton = new Button();
            serverLoginTextbox = new TextBox();
            serverPasswordTextbox = new TextBox();
            serverLoginLabel = new Label();
            serverPasswordLabel = new Label();
            isWindowsAuthenticationCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // serverNameComboBox
            //
            serverNameComboBox.FormattingEnabled = true;
            serverNameComboBox.Location = new Point(202, 41);
            serverNameComboBox.Name = "serverNameComboBox";
            serverNameComboBox.Size = new Size(251, 23);
            serverNameComboBox.TabIndex = 0;
            serverNameComboBox.DropDown += serverNameComboBox_DropDown;
            // 
            // newDatabaseTextbox
            // 
            newDatabaseTextbox.Location = new Point(202, 81);
            newDatabaseTextbox.Name = "newDatabaseTextbox";
            newDatabaseTextbox.Size = new Size(251, 23);
            newDatabaseTextbox.TabIndex = 1;
            newDatabaseTextbox.TextChanged += NewDatabaseTextbox_TextChanged;
            // 
            // serverNameLabel
            // 
            serverNameLabel.AutoSize = true;
            serverNameLabel.Location = new Point(83, 44);
            serverNameLabel.Name = "serverNameLabel";
            serverNameLabel.Size = new Size(72, 15);
            serverNameLabel.TabIndex = 2;
            serverNameLabel.Text = "Server name";
            serverNameLabel.Click += Label1_Click;
            // 
            // newDatabaseNameLabel
            // 
            newDatabaseNameLabel.AutoSize = true;
            newDatabaseNameLabel.Location = new Point(83, 84);
            newDatabaseNameLabel.Name = "newDatabaseNameLabel";
            newDatabaseNameLabel.Size = new Size(114, 15);
            newDatabaseNameLabel.TabIndex = 3;
            newDatabaseNameLabel.Text = "New database name";
            newDatabaseNameLabel.Click += Label2_Click;
            // 
            // createButton
            // 
            createButton.Location = new Point(202, 221);
            createButton.Name = "createButton";
            createButton.Size = new Size(128, 23);
            createButton.TabIndex = 4;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += CreateButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(336, 221);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(117, 23);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click_1;
            // 
            // serverLoginTextbox
            // 
            serverLoginTextbox.Location = new Point(202, 121);
            serverLoginTextbox.Name = "serverLoginTextbox";
            serverLoginTextbox.Size = new Size(251, 23);
            serverLoginTextbox.TabIndex = 6;
            // 
            // serverPasswordTextbox
            // 
            serverPasswordTextbox.Location = new Point(202, 158);
            serverPasswordTextbox.Name = "serverPasswordTextbox";
            serverPasswordTextbox.Size = new Size(251, 23);
            serverPasswordTextbox.TabIndex = 7;
            // 
            // serverLoginLabel
            // 
            serverLoginLabel.AutoSize = true;
            serverLoginLabel.Location = new Point(83, 121);
            serverLoginLabel.Name = "serverLoginLabel";
            serverLoginLabel.Size = new Size(69, 15);
            serverLoginLabel.TabIndex = 8;
            serverLoginLabel.Text = "Server login";
            serverLoginLabel.Click += Label3_Click;
            // 
            // serverPasswordLabel
            // 
            serverPasswordLabel.AutoSize = true;
            serverPasswordLabel.Location = new Point(83, 158);
            serverPasswordLabel.Name = "serverPasswordLabel";
            serverPasswordLabel.Size = new Size(92, 15);
            serverPasswordLabel.TabIndex = 9;
            serverPasswordLabel.Text = "Server password";
            // 
            // isWindowsAuthenticationCheckbox
            // 
            isWindowsAuthenticationCheckbox.AutoSize = true;
            isWindowsAuthenticationCheckbox.Location = new Point(202, 187);
            isWindowsAuthenticationCheckbox.Name = "isWindowsAuthenticationCheckbox";
            isWindowsAuthenticationCheckbox.Size = new Size(205, 19);
            isWindowsAuthenticationCheckbox.TabIndex = 10;
            isWindowsAuthenticationCheckbox.Text = "Authenticate with Windows Login";
            isWindowsAuthenticationCheckbox.UseVisualStyleBackColor = true;
            isWindowsAuthenticationCheckbox.CheckedChanged += isWindowsAuthenticationCheckbox_CheckedChanged;
            // 
            // NewDatabaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 298);
            Controls.Add(isWindowsAuthenticationCheckbox);
            Controls.Add(serverPasswordLabel);
            Controls.Add(serverLoginLabel);
            Controls.Add(serverPasswordTextbox);
            Controls.Add(serverLoginTextbox);
            Controls.Add(cancelButton);
            Controls.Add(createButton);
            Controls.Add(newDatabaseNameLabel);
            Controls.Add(serverNameLabel);
            Controls.Add(newDatabaseTextbox);
            Controls.Add(serverNameComboBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "NewDatabaseForm";
            Text = "Create new database";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ServerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void NewDatabaseTextbox_TextChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        #endregion

        private ComboBox serverNameComboBox;
        private TextBox newDatabaseTextbox;
        private Label serverNameLabel;
        private Label newDatabaseNameLabel;
        private Button createButton;
        private Button cancelButton;
        private TextBox serverLoginTextbox;
        private TextBox serverPasswordTextbox;
        private Label serverLoginLabel;
        private Label serverPasswordLabel;
        private CheckBox isWindowsAuthenticationCheckbox;
    }
}