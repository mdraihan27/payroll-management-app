namespace Payroll_Management_App
{
    partial class EmployeeRegForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            nameTextBox = new TextBox();
            designationTextBox = new TextBox();
            label2 = new Label();
            presentAddressTextBox = new TextBox();
            label3 = new Label();
            permanentAddressTextBox = new TextBox();
            label4 = new Label();
            salaryTextBox = new TextBox();
            label5 = new Label();
            birthDateTimePicker = new DateTimePicker();
            label6 = new Label();
            button1 = new Button();
            phoneTextBox = new TextBox();
            label7 = new Label();
            genderComboBox = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 54);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Employee Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(183, 51);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(208, 23);
            nameTextBox.TabIndex = 1;
            // 
            // designationTextBox
            // 
            designationTextBox.Location = new Point(183, 133);
            designationTextBox.Name = "designationTextBox";
            designationTextBox.Size = new Size(208, 23);
            designationTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 136);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Designation";
            // 
            // presentAddressTextBox
            // 
            presentAddressTextBox.Location = new Point(183, 173);
            presentAddressTextBox.Name = "presentAddressTextBox";
            presentAddressTextBox.Size = new Size(208, 23);
            presentAddressTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 176);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 4;
            label3.Text = "Present Address";
            label3.UseWaitCursor = true;
            // 
            // permanentAddressTextBox
            // 
            permanentAddressTextBox.Location = new Point(183, 213);
            permanentAddressTextBox.Name = "permanentAddressTextBox";
            permanentAddressTextBox.Size = new Size(208, 23);
            permanentAddressTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 216);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 6;
            label4.Text = "Permanent Address";
            label4.UseWaitCursor = true;
            // 
            // salaryTextBox
            // 
            salaryTextBox.Location = new Point(183, 255);
            salaryTextBox.Name = "salaryTextBox";
            salaryTextBox.Size = new Size(208, 23);
            salaryTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 258);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 8;
            label5.Text = "Salary";
            label5.UseWaitCursor = true;
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Location = new Point(183, 91);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(208, 23);
            birthDateTimePicker.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 95);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 11;
            label6.Text = "Date of Birth";
            label6.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(169, 418);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 12;
            button1.Text = "Save Employee";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(183, 299);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(208, 23);
            phoneTextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 302);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 13;
            label7.Text = "Phone";
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.Items.AddRange(new object[] { "Choose", "M", "F" });
            genderComboBox.Location = new Point(184, 344);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(121, 23);
            genderComboBox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 348);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 16;
            label8.Text = "Gender";
            // 
            // EmployeeRegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 482);
            Controls.Add(label8);
            Controls.Add(genderComboBox);
            Controls.Add(phoneTextBox);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(birthDateTimePicker);
            Controls.Add(salaryTextBox);
            Controls.Add(label5);
            Controls.Add(permanentAddressTextBox);
            Controls.Add(label4);
            Controls.Add(presentAddressTextBox);
            Controls.Add(label3);
            Controls.Add(designationTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "EmployeeRegForm";
            Text = "Employee Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private TextBox designationTextBox;
        private Label label2;
        private TextBox presentAddressTextBox;
        private Label label3;
        private TextBox permanentAddressTextBox;
        private Label label4;
        private TextBox salaryTextBox;
        private Label label5;
        private DateTimePicker birthDateTimePicker;
        private Label label6;
        private Button button1;
        private TextBox phoneTextBox;
        private Label label7;
        private ComboBox genderComboBox;
        private Label label8;
    }
}
