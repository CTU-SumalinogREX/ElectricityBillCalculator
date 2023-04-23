﻿namespace ElectricityBillCalculator
{
    partial class Form2
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
            addName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addWattage = new TextBox();
            label4 = new Label();
            addHrs = new TextBox();
            cancelButton = new Button();
            addButton = new Button();
            SuspendLayout();
            // 
            // addName
            // 
            addName.Location = new Point(56, 44);
            addName.Name = "addName";
            addName.Size = new Size(181, 23);
            addName.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(249, 41);
            label1.TabIndex = 1;
            label1.Text = "Add new Appliance";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Wattage:";
            // 
            // addWattage
            // 
            addWattage.Location = new Point(72, 73);
            addWattage.MaxLength = 5;
            addWattage.Name = "addWattage";
            addWattage.Size = new Size(165, 23);
            addWattage.TabIndex = 3;
            addWattage.KeyPress += addWattage_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 105);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Hours/Day:";
            // 
            // addHrs
            // 
            addHrs.Location = new Point(85, 102);
            addHrs.MaxLength = 2;
            addHrs.Name = "addHrs";
            addHrs.Size = new Size(152, 23);
            addHrs.TabIndex = 5;
            addHrs.KeyPress += addHrs_KeyPress;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(35, 135);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(146, 135);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 171);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            Controls.Add(label4);
            Controls.Add(addHrs);
            Controls.Add(label3);
            Controls.Add(addWattage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addName);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox addName;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox addWattage;
        private Label label4;
        private TextBox addHrs;
        private Button cancelButton;
        private Button addButton;
    }
}