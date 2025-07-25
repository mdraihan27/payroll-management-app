namespace Payroll_Management_App
{
    partial class HomePage
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
            addNewEmployeeButton = new Button();
            refreshEmployeeList = new Button();
            removeSelectedButton = new Button();
            employeeListView = new ListView();
            panel1 = new Panel();
            paySalaryButton = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(33, 37, 41);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 0;
            label1.Text = "Employee List";
            // 
            // addNewEmployeeButton
            // 
            addNewEmployeeButton.BackColor = Color.FromArgb(40, 167, 69);
            addNewEmployeeButton.FlatAppearance.BorderSize = 0;
            addNewEmployeeButton.FlatStyle = FlatStyle.Flat;
            addNewEmployeeButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addNewEmployeeButton.ForeColor = Color.White;
            addNewEmployeeButton.Location = new Point(20, 50);
            addNewEmployeeButton.Name = "addNewEmployeeButton";
            addNewEmployeeButton.Size = new Size(160, 50);
            addNewEmployeeButton.TabIndex = 0;
            addNewEmployeeButton.Text = "Add New Employee";
            addNewEmployeeButton.UseVisualStyleBackColor = false;
            addNewEmployeeButton.Click += addNewEmployeeButton_Click;
            // 
            // refreshEmployeeList
            // 
            refreshEmployeeList.BackColor = Color.FromArgb(0, 123, 255);
            refreshEmployeeList.FlatAppearance.BorderSize = 0;
            refreshEmployeeList.FlatStyle = FlatStyle.Flat;
            refreshEmployeeList.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            refreshEmployeeList.ForeColor = Color.White;
            refreshEmployeeList.Location = new Point(20, 120);
            refreshEmployeeList.Name = "refreshEmployeeList";
            refreshEmployeeList.Size = new Size(160, 50);
            refreshEmployeeList.TabIndex = 1;
            refreshEmployeeList.Text = "Refresh List";
            refreshEmployeeList.UseVisualStyleBackColor = false;
            refreshEmployeeList.Click += refreshEmployeeLIst_Click;
            // 
            // removeSelectedButton
            // 
            removeSelectedButton.BackColor = Color.FromArgb(220, 53, 69);
            removeSelectedButton.FlatAppearance.BorderSize = 0;
            removeSelectedButton.FlatStyle = FlatStyle.Flat;
            removeSelectedButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            removeSelectedButton.ForeColor = Color.White;
            removeSelectedButton.Location = new Point(20, 190);
            removeSelectedButton.Name = "removeSelectedButton";
            removeSelectedButton.Size = new Size(160, 50);
            removeSelectedButton.TabIndex = 2;
            removeSelectedButton.Text = "Remove Selected";
            removeSelectedButton.UseVisualStyleBackColor = false;
            removeSelectedButton.Click += removeSelectedButton_Click;
            // 
            // employeeListView
            // 
            employeeListView.BackColor = Color.White;
            employeeListView.BorderStyle = BorderStyle.None;
            employeeListView.CheckBoxes = true;
            employeeListView.Font = new Font("Segoe UI", 9F);
            employeeListView.FullRowSelect = true;
            employeeListView.GridLines = true;
            employeeListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            employeeListView.Location = new Point(20, 60);
            employeeListView.Name = "employeeListView";
            employeeListView.Size = new Size(1208, 645);
            employeeListView.TabIndex = 1;
            employeeListView.UseCompatibleStateImageBehavior = false;
            employeeListView.View = View.Details;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 58, 64);
            panel1.Controls.Add(paySalaryButton);
            panel1.Controls.Add(addNewEmployeeButton);
            panel1.Controls.Add(refreshEmployeeList);
            panel1.Controls.Add(removeSelectedButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 725);
            panel1.TabIndex = 0;
            // 
            // paySalaryButton
            // 
            paySalaryButton.BackColor = Color.DarkSlateBlue;
            paySalaryButton.FlatAppearance.BorderSize = 0;
            paySalaryButton.FlatStyle = FlatStyle.Flat;
            paySalaryButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            paySalaryButton.ForeColor = Color.White;
            paySalaryButton.Location = new Point(20, 260);
            paySalaryButton.Name = "paySalaryButton";
            paySalaryButton.Size = new Size(160, 50);
            paySalaryButton.TabIndex = 3;
            paySalaryButton.Text = "Pay Salary";
            paySalaryButton.UseVisualStyleBackColor = false;
            paySalaryButton.Click += paySalaryButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 249, 250);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(employeeListView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1247, 725);
            panel2.TabIndex = 1;

            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1447, 725);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HomePage";
            Text = "Payroll Management System";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
        private Button addNewEmployeeButton;
        private Button refreshEmployeeList;
        private Button removeSelectedButton;
        private ListView employeeListView;
        private Panel panel1;
        private Panel panel2;
        private Button paySalaryButton;
    }


}
