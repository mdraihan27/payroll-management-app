namespace Payroll_Management_App
{
    partial class EmployeeRegForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

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
            employeeIdTextBox = new TextBox();
            label9 = new Label();
            employeeTypeTextBox = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(33, 37, 41);
            label1.Location = new Point(30, 70);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Employee Name";
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Segoe UI", 9F);
            nameTextBox.Location = new Point(150, 67);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(250, 23);
            nameTextBox.TabIndex = 1;
            // 
            // designationTextBox
            // 
            designationTextBox.BorderStyle = BorderStyle.FixedSingle;
            designationTextBox.Font = new Font("Segoe UI", 9F);
            designationTextBox.Location = new Point(150, 189);
            designationTextBox.Name = "designationTextBox";
            designationTextBox.Size = new Size(250, 23);
            designationTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(33, 37, 41);
            label2.Location = new Point(30, 192);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Designation";
            // 
            // presentAddressTextBox
            // 
            presentAddressTextBox.BorderStyle = BorderStyle.FixedSingle;
            presentAddressTextBox.Font = new Font("Segoe UI", 9F);
            presentAddressTextBox.Location = new Point(150, 229);
            presentAddressTextBox.Name = "presentAddressTextBox";
            presentAddressTextBox.Size = new Size(250, 23);
            presentAddressTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(33, 37, 41);
            label3.Location = new Point(30, 232);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 4;
            label3.Text = "Present Address";
            // 
            // permanentAddressTextBox
            // 
            permanentAddressTextBox.BorderStyle = BorderStyle.FixedSingle;
            permanentAddressTextBox.Font = new Font("Segoe UI", 9F);
            permanentAddressTextBox.Location = new Point(150, 269);
            permanentAddressTextBox.Name = "permanentAddressTextBox";
            permanentAddressTextBox.Size = new Size(250, 23);
            permanentAddressTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(33, 37, 41);
            label4.Location = new Point(30, 272);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 6;
            label4.Text = "Permanent Address";
            // 
            // salaryTextBox
            // 
            salaryTextBox.BorderStyle = BorderStyle.FixedSingle;
            salaryTextBox.Font = new Font("Segoe UI", 9F);
            salaryTextBox.Location = new Point(150, 309);
            salaryTextBox.Name = "salaryTextBox";
            salaryTextBox.Size = new Size(250, 23);
            salaryTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(33, 37, 41);
            label5.Location = new Point(30, 312);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 8;
            label5.Text = "Salary";
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Font = new Font("Segoe UI", 9F);
            birthDateTimePicker.Location = new Point(150, 107);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(250, 23);
            birthDateTimePicker.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(33, 37, 41);
            label6.Location = new Point(30, 110);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 11;
            label6.Text = "Date of Birth";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 167, 69);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(154, 442);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 12;
            button1.Text = "Save Employee";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // phoneTextBox
            // 
            phoneTextBox.BorderStyle = BorderStyle.FixedSingle;
            phoneTextBox.Font = new Font("Segoe UI", 9F);
            phoneTextBox.Location = new Point(150, 349);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(250, 23);
            phoneTextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(33, 37, 41);
            label7.Location = new Point(30, 352);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 13;
            label7.Text = "Phone";
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.Font = new Font("Segoe UI", 9F);
            genderComboBox.Items.AddRange(new object[] { "Choose", "M", "F" });
            genderComboBox.Location = new Point(150, 389);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(150, 23);
            genderComboBox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(33, 37, 41);
            label8.Location = new Point(30, 392);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 16;
            label8.Text = "Gender";
            // 
            // employeeIdTextBox
            // 
            employeeIdTextBox.BackColor = Color.FromArgb(233, 236, 239);
            employeeIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            employeeIdTextBox.Font = new Font("Segoe UI", 9F);
            employeeIdTextBox.Location = new Point(150, 27);
            employeeIdTextBox.Name = "employeeIdTextBox";
            employeeIdTextBox.ReadOnly = true;
            employeeIdTextBox.Size = new Size(250, 23);
            employeeIdTextBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(33, 37, 41);
            label9.Location = new Point(30, 30);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 18;
            label9.Text = "Employee ID";
            // 
            // employeeTypeTextBox
            // 
            employeeTypeTextBox.BorderStyle = BorderStyle.FixedSingle;
            employeeTypeTextBox.Font = new Font("Segoe UI", 9F);
            employeeTypeTextBox.Location = new Point(150, 148);
            employeeTypeTextBox.Name = "employeeTypeTextBox";
            employeeTypeTextBox.Size = new Size(250, 23);
            employeeTypeTextBox.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(33, 37, 41);
            label10.Location = new Point(30, 151);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 19;
            label10.Text = "Employee Type";
            // 
            // EmployeeRegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(450, 511);
            Controls.Add(employeeTypeTextBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(employeeIdTextBox);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmployeeRegForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Employee Registration";
            ResumeLayout(false);
            PerformLayout();
        }

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
        private TextBox employeeIdTextBox;
        private Label label9;
        private TextBox employeeTypeTextBox;
        private Label label10;
    }
}
