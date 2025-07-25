using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management_App
{
    public partial class HomePage : System.Windows.Forms.Form
    {
        public HomePage()
        {
            InitializeComponent();
            SetupListViewColumns(); 
            LoadEmployees();
        }

        private void SetupListViewColumns()
        {
            employeeListView.Columns.Clear();
            employeeListView.Columns.Add("Employee ID", 100);
            employeeListView.Columns.Add("Name", 150);
            employeeListView.Columns.Add("Employee Type", 120);
            employeeListView.Columns.Add("Designation", 120);
            employeeListView.Columns.Add("Salary", 100);
            employeeListView.Columns.Add("Phone", 120);
            employeeListView.Columns.Add("Present Address", 180);
            employeeListView.Columns.Add("Permanent Address", 180);
            employeeListView.Columns.Add("Date of Birth", 120);
            employeeListView.Columns.Add("Gender", 80);
            
            Width = 1530;
            employeeListView.Width = 1400; 
        }

        private void addNewEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeRegForm employeeRegForm = new EmployeeRegForm();
            if (employeeRegForm.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees();
            }
        }

        private void refreshEmployeeLIst_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            List<string> selectedEmployeeIds = new List<string>();

            foreach (ListViewItem item in employeeListView.CheckedItems)
            {
                selectedEmployeeIds.Add(item.SubItems[0].Text);
            }

            if (selectedEmployeeIds.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to remove {selectedEmployeeIds.Count} selected employee(s)?",
                    "Confirm Removal",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ModifyEmployeesTextFile modifyEmployeesTextFile = new ModifyEmployeesTextFile();
                    modifyEmployeesTextFile.RemoveEmployees(selectedEmployeeIds);
                    LoadEmployees();
                    MessageBox.Show($"{selectedEmployeeIds.Count} employee(s) removed successfully.", "Success");
                }
            }
            else
            {
                MessageBox.Show("Please select at least one employee to remove.", "No Selection");
            }
        }

        private void LoadEmployees()
        {
            employeeListView.Items.Clear();
            ModifyEmployeesTextFile modifyEmployeesTextFile = new ModifyEmployeesTextFile();
            List<string> employeeStringsList = modifyEmployeesTextFile.GetAllEmployees();

            foreach (string employeeString in employeeStringsList)
            {
                if (!string.IsNullOrWhiteSpace(employeeString))
                {
                    string[] employeeDetails = employeeString.Split(',');
                    if (employeeDetails.Length >= 10)
                    {
                        ListViewItem item = new ListViewItem(employeeDetails[0]); // Employee ID
                        item.SubItems.Add(employeeDetails[1]); // Name
                        item.SubItems.Add(employeeDetails[2]); // Employee Type
                        item.SubItems.Add(employeeDetails[3]); // Designation
                        item.SubItems.Add(employeeDetails[4]); // Salary
                        item.SubItems.Add(employeeDetails[5]); // Phone
                        item.SubItems.Add(employeeDetails[6]); // Present Address
                        item.SubItems.Add(employeeDetails[7]); // Permanent Address
                        item.SubItems.Add(employeeDetails[8]); // Date of Birth
                        item.SubItems.Add(employeeDetails[9]); // Gender
                        employeeListView.Items.Add(item);
                    }
                }
            }
        }


        private void paySalaryButton_Click(object sender, EventArgs e)
        {
            PaySalaryForm paySalaryForm = new PaySalaryForm();
            paySalaryForm.ShowDialog();
        }
    }
}
