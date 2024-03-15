namespace WMS___Projekt.Forms
{
    partial class AddElementForm
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
            confirmButton = new Button();
            cancelButton = new Button();
            label1 = new Label();
            label2 = new Label();
            makeTextbox = new TextBox();
            modelTextbox = new TextBox();
            priceTextbox = new TextBox();
            yearTextbox = new TextBox();
            colorTextbox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(256, 228);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(75, 23);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click_1;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(337, 228);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 21);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "Manufacturer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 50);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Model";
            // 
            // makeTextbox
            // 
            makeTextbox.Location = new Point(159, 18);
            makeTextbox.Name = "makeTextbox";
            makeTextbox.Size = new Size(253, 23);
            makeTextbox.TabIndex = 4;
            // 
            // modelTextbox
            // 
            modelTextbox.Location = new Point(159, 47);
            modelTextbox.Name = "modelTextbox";
            modelTextbox.Size = new Size(253, 23);
            modelTextbox.TabIndex = 5;
            // 
            // priceTextbox
            // 
            priceTextbox.Location = new Point(159, 105);
            priceTextbox.Name = "priceTextbox";
            priceTextbox.Size = new Size(253, 23);
            priceTextbox.TabIndex = 7;
            // 
            // yearTextbox
            // 
            yearTextbox.Location = new Point(159, 76);
            yearTextbox.Name = "yearTextbox";
            yearTextbox.Size = new Size(253, 23);
            yearTextbox.TabIndex = 6;
            // 
            // colorTextbox
            // 
            colorTextbox.Location = new Point(159, 134);
            colorTextbox.Name = "colorTextbox";
            colorTextbox.Size = new Size(253, 23);
            colorTextbox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 79);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 10;
            label3.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 108);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 9;
            label4.Text = "Price";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 137);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Color";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 263);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(colorTextbox);
            Controls.Add(priceTextbox);
            Controls.Add(yearTextbox);
            Controls.Add(modelTextbox);
            Controls.Add(makeTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirmButton;
        private Button cancelButton;
        private Label label1;
        private Label label2;
        private TextBox makeTextbox;
        private TextBox modelTextbox;
        private TextBox priceTextbox;
        private TextBox yearTextbox;
        private TextBox colorTextbox;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}