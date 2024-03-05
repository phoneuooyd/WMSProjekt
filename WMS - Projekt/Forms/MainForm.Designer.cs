using WMS___Projekt.DataAccess;

namespace WMS___Projekt.Forms
{
    partial class MainForm
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
            panel1 = new Panel();
            loadDatagrid = new Button();
            button5 = new Button();
            button4 = new Button();
            panelDatagrid = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            addButton = new Button();
            delButton = new Button();
            panel1.SuspendLayout();
            panelDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(loadDatagrid);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 430);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // loadDatagrid
            // 
            loadDatagrid.Location = new Point(8, 90);
            loadDatagrid.Name = "loadDatagrid";
            loadDatagrid.Size = new Size(139, 44);
            loadDatagrid.TabIndex = 5;
            loadDatagrid.Text = "Load dummy data";
            loadDatagrid.UseVisualStyleBackColor = true;
            loadDatagrid.Click += loadDatagrid_Click;
            // 
            // button5
            // 
            button5.Location = new Point(8, 44);
            button5.Name = "button5";
            button5.Size = new Size(142, 23);
            button5.TabIndex = 4;
            button5.Text = "Change database";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(8, 12);
            button4.Name = "button4";
            button4.Size = new Size(142, 23);
            button4.TabIndex = 3;
            button4.Text = "New database";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panelDatagrid
            // 
            panelDatagrid.Controls.Add(dataGridView1);
            panelDatagrid.Location = new Point(153, 73);
            panelDatagrid.Name = "panelDatagrid";
            panelDatagrid.Size = new Size(622, 356);
            panelDatagrid.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(630, 333);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(delButton);
            panel2.Location = new Point(153, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(636, 84);
            panel2.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 55);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // delButton
            // 
            delButton.Location = new Point(112, 12);
            delButton.Name = "delButton";
            delButton.Size = new Size(94, 55);
            delButton.TabIndex = 2;
            delButton.Text = "Delete";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += deleteButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 430);
            Controls.Add(panelDatagrid);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panelDatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button4;
        private Panel panelDatagrid;
        private Button loadDatagrid;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button addButton;
        private Button delButton;
    }
}