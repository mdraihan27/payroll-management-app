namespace Payroll_Management_App
{
    public partial class EmployeeRegForm : System.Windows.Forms.Form
    {
        public EmployeeRegForm()
        {
            InitializeComponent();
            ModifyEmployeesTextFile modifyFile = new ModifyEmployeesTextFile();
            this.employeeIdTextBox.Text = GetNextEmployeeId();
        }

        private string GetNextEmployeeId()
        {
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?
                             .Parent?.Parent?.Parent?.FullName ?? AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(projectDir, "employees.txt");

            if (!File.Exists(filePath))
            {
                return "EMP001";
            }

            var lines = File.ReadAllLines(filePath);
            if (lines.Length == 0)
            {
                return "EMP001";
            }

            int maxId = 0;
            foreach (var line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    var parts = line.Split(',');
                    if (parts.Length > 0 && parts[0].StartsWith("EMP"))
                    {
                        if (int.TryParse(parts[0].Substring(3), out int currentId))
                        {
                            maxId = Math.Max(maxId, currentId);
                        }
                    }
                }
            }

            return $"EMP{(maxId + 1):D3}";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string employeeName = this.nameTextBox.Text;
            string employeeDesignation = this.designationTextBox.Text;
            string dateOfBirth = this.birthDateTimePicker.Text;
            string salary = this.salaryTextBox.Text;
            string presentAddress = this.presentAddressTextBox.Text;
            string permanentAddress = this.permanentAddressTextBox.Text;
            string phoneNumber = this.phoneTextBox.Text;
            string gender = this.genderComboBox.Text;
            string employeeType = this.employeeTypeTextBox.Text;

            if (string.IsNullOrWhiteSpace(employeeName) ||
                string.IsNullOrWhiteSpace(employeeDesignation) ||
                string.IsNullOrWhiteSpace(dateOfBirth) ||
                string.IsNullOrWhiteSpace(salary) ||
                string.IsNullOrWhiteSpace(presentAddress) ||
                string.IsNullOrWhiteSpace(permanentAddress) ||
                string.IsNullOrWhiteSpace(phoneNumber) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(employeeType) ||

                gender.Equals("Choose"))
            {
                MessageBox.Show("Please fill in all fields before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dateOfBirth = dateOfBirth.Split(',')[1];
            if (gender.Equals("M"))
            {
                gender = "Male";
            }
            else if (gender.Equals("F"))
            {
                gender = "Female";
            }

            ModifyEmployeesTextFile modifyEmployeesTextFile = new ModifyEmployeesTextFile();
            modifyEmployeesTextFile.AddNewEmployee(employeeName, dateOfBirth, employeeType, employeeDesignation, presentAddress, permanentAddress, salary, phoneNumber, gender);

            MessageBox.Show("Employee saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
