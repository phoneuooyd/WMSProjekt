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
            button5 = new Button();
            button4 = new Button();
            delButton = new Button();
            modButton = new Button();
            addButton = new Button();
            panel2 = new Panel();
            panelDatagrid = new Panel();
            dataGridView1 = new DataGridView();
            loadDatagrid = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Size = new Size(153, 484);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button5
            // 
            button5.Location = new Point(8, 44);
            button5.Name = "button5";
            button5.Size = new Size(142, 23);
            button5.TabIndex = 4;
            button5.Text = "Change database";
            button5.UseVisualStyleBackColor = true;
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
            // delButton
            // 
            delButton.Location = new Point(212, 12);
            delButton.Name = "delButton";
            delButton.Size = new Size(94, 55);
            delButton.TabIndex = 2;
            delButton.Text = "Delete";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += button3_Click;
            // 
            // modButton
            // 
            modButton.Location = new Point(112, 12);
            modButton.Name = "modButton";
            modButton.Size = new Size(94, 55);
            modButton.TabIndex = 1;
            modButton.Text = "Modify";
            modButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 55);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(modButton);
            panel2.Controls.Add(delButton);
            panel2.Location = new Point(153, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 84);
            panel2.TabIndex = 1;
            // 
            // panelDatagrid
            // 
            panelDatagrid.Controls.Add(dataGridView1);
            panelDatagrid.Location = new Point(153, 73);
            panelDatagrid.Name = "panelDatagrid";
            panelDatagrid.Size = new Size(770, 408);
            panelDatagrid.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(745, 333);
            dataGridView1.TabIndex = 0;
            // 
            // loadDatagrid
            // 
            loadDatagrid.Location = new Point(8, 110);
            loadDatagrid.Name = "loadDatagrid";
            loadDatagrid.Size = new Size(139, 44);
            loadDatagrid.TabIndex = 5;
            loadDatagrid.Text = "Load all data";
            loadDatagrid.UseVisualStyleBackColor = true;
            loadDatagrid.Click += loadDatagrid_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 484);
            Controls.Add(panelDatagrid);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panelDatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button delButton;
        private Button modButton;
        private Button addButton;
        private Button button5;
        private Button button4;
        private Panel panel2;
        private Panel panelDatagrid;
        private DataGridView dataGridView1;
        private Button loadDatagrid;
    }
}