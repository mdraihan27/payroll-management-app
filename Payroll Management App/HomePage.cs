using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Payroll_Management_App.ModifyEmployeesTextFile;
namespace Payroll_Management_App
{
    public partial class HomePage : System.Windows.Forms.Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void addNewEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeRegForm employeeRegForm = new EmployeeRegForm();
            employeeRegForm.ShowDialog();
        }

        private void refreshEmployeeLIst_Click(object sender, EventArgs e)
        {
            ModifyEmployeesTextFile modifyEmployeesTextFile = new ModifyEmployeesTextFile();
            List<string> employeeStringsList = modifyEmployeesTextFile.GetAllEmployees();
            foreach (string employeeString in employeeStringsList)
            {
            
                string[] employeeDetails = employeeString.Split(',');
                if (employeeDetails.Length >= 8)
                {
                    employeeDataGridView.Rows.Add(employeeDetails);
                }
            }
        }
    }
}
