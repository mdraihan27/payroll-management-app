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

            this.salaryTextBox.Text = employeeName;
            
        }

       
    }
}
