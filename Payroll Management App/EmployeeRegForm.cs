using static Payroll_Management_App.ModifyEmployeesTextFile;

namespace Payroll_Management_App
{
    public partial class EmployeeRegForm : System.Windows.Forms.Form
    {
        public EmployeeRegForm()
        {
            InitializeComponent();
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

            if (string.IsNullOrWhiteSpace(employeeName) ||
                string.IsNullOrWhiteSpace(employeeDesignation) ||
                string.IsNullOrWhiteSpace(dateOfBirth) ||
                string.IsNullOrWhiteSpace(salary) ||
                string.IsNullOrWhiteSpace(presentAddress) ||
                string.IsNullOrWhiteSpace(permanentAddress) ||
                string.IsNullOrWhiteSpace(phoneNumber) ||
                string.IsNullOrWhiteSpace(gender) ||
                gender.Equals("Choose"))
            {
                MessageBox.Show("Please fill in all fields before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dateOfBirth = dateOfBirth.Split(',')[1]; //date of birth থেকে শুধু তারিখ রাখব, বার টা বাদ দিয়ে দিব 
            if (gender.Equals("M"))
            {
                gender = "Male";
            }else if (gender.Equals("F"))
            {
                gender = "Female";
            }

                ModifyEmployeesTextFile modifyEmployeesTextFile = new ModifyEmployeesTextFile();
            modifyEmployeesTextFile.AddNewEmployee(employeeName, dateOfBirth, employeeDesignation, presentAddress, permanentAddress, salary, phoneNumber, gender);

        }

       
    }
}
