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
    public class EmployeeAllowancesDeductions
    {
        public decimal HouseRentAllowance { get; set; }
        public decimal MedicalAllowance { get; set; }
        public decimal EducationAllowance { get; set; }
        public decimal TelephoneAllowance { get; set; }
        public decimal FestivalBonus { get; set; }
        public decimal TransportAllowance { get; set; }
        public decimal OthersAllowance { get; set; }
        
        public decimal GPF { get; set; }
        public decimal HouseRentDeduction { get; set; }
        public decimal InsurancePremium { get; set; }
        public decimal ElectricityBill { get; set; }
        public decimal TransportBill { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal OthersDeduction { get; set; }
    }

    public partial class PaySalaryForm : System.Windows.Forms.Form
    {
        private ModifyEmployeesTextFile modifyFile;
        private Dictionary<string, EmployeeAllowancesDeductions> employeeData;
        private string? currentEmployeeId;
        private bool isLoading = false;

        public PaySalaryForm()
        {
            InitializeComponent();
            modifyFile = new ModifyEmployeesTextFile();
            employeeData = new Dictionary<string, EmployeeAllowancesDeductions>();
            
            // Set default month to current month
            monthComboBox.SelectedIndex = DateTime.Now.Month - 1;
            
            // Load employees into dropdown
            LoadEmployees();
            
            // Wire up the event handler
            employeeSelectionComboBox.SelectedIndexChanged += employeeSelectionComboBox_SelectedIndexChanged;
            
            // Wire up text changed events to save data automatically
            WireUpTextBoxEvents();
        }

        private void WireUpTextBoxEvents()
        {
            // Allowances
            houseRentAllowanceTextBox.TextChanged += (s, e) => SaveCurrentEmployeeDataIfSelected();
            medicalAllowanceTextBox.TextChanged += (s, e) => SaveCurrentEmployeeDataIfSelected();
            educationAllowanceTextBox.TextChanged += (s, e) => SaveCurrentEmployeeDataIfSelected();
            telephoneAllowanceTextBox.TextChanged += (s, e) => SaveCurrentEmployeeDataIfSelected();
            festivalBonusTextBox.TextChanged += (s, e) => SaveCurrentEmployeeDataIfSelected();
            transportAllowanceTextBox.TextChanged += (s, e) => SaveCurrentEmployeeDataIfSelected();
            othersAllowanceTextBox.TextChanged += (s, e) => SaveCurrentEmployeeDataIfSelected();
            
            // Deductions
            gpfTextBox.TextChanged += (s, e) => SaveCurrentEmployeeDataIfSelected();
            houseRentDeductionTextBox.TextChanged += (s, e) => SaveCurrentEmployeeDataIfSelected();
            insurancePremiumTextBox.TextChanged += (s, e) => SaveCurrentEmployeeDataIfSelected();
            electricityBillTextBox.TextChanged += (s, e) => SaveCurrentEmployeeDataIfSelected();
            transportBillTextBox.TextChanged += (s, e) => SaveCurrentEmployeeDataIfSelected();
            incomeTaxTextBox.TextChanged += (s, e) => SaveCurrentEmployeeDataIfSelected();
            othersDeductionTextBox.TextChanged += (s, e) => SaveCurrentEmployeeDataIfSelected();
        }

        private void SaveCurrentEmployeeDataIfSelected()
        {
            if (!isLoading && !string.IsNullOrEmpty(currentEmployeeId))
            {
                SaveCurrentEmployeeData();
            }
        }

        private void LoadEmployees()
        {
            try
            {
                var employees = modifyFile.GetAllEmployees();
                employeeSelectionComboBox.Items.Clear();
                
                foreach (string employeeInfo in employees)
                {
                    if (!string.IsNullOrWhiteSpace(employeeInfo))
                    {
                        string[] details = employeeInfo.Split(',');
                        if (details.Length >= 2)
                        {
                            string displayText = $"{details[0]} - {details[1]}"; // ID - Name
                            employeeSelectionComboBox.Items.Add(displayText);
                            
                            // Initialize empty data for this employee
                            if (!employeeData.ContainsKey(details[0]))
                            {
                                employeeData[details[0]] = new EmployeeAllowancesDeductions();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}", "Error");
            }
        }

        private void employeeSelectionComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (employeeSelectionComboBox.SelectedItem != null)
            {
                // Load data for selected employee
                LoadSelectedEmployeeData();
            }
        }

        private void SaveCurrentEmployeeData()
        {
            if (!string.IsNullOrEmpty(currentEmployeeId) && employeeData.ContainsKey(currentEmployeeId))
            {
                var data = employeeData[currentEmployeeId];
                
                // Save allowances
                data.HouseRentAllowance = GetDecimalValue(houseRentAllowanceTextBox.Text);
                data.MedicalAllowance = GetDecimalValue(medicalAllowanceTextBox.Text);
                data.EducationAllowance = GetDecimalValue(educationAllowanceTextBox.Text);
                data.TelephoneAllowance = GetDecimalValue(telephoneAllowanceTextBox.Text);
                data.FestivalBonus = GetDecimalValue(festivalBonusTextBox.Text);
                data.TransportAllowance = GetDecimalValue(transportAllowanceTextBox.Text);
                data.OthersAllowance = GetDecimalValue(othersAllowanceTextBox.Text);
                
                // Save deductions
                data.GPF = GetDecimalValue(gpfTextBox.Text);
                data.HouseRentDeduction = GetDecimalValue(houseRentDeductionTextBox.Text);
                data.InsurancePremium = GetDecimalValue(insurancePremiumTextBox.Text);
                data.ElectricityBill = GetDecimalValue(electricityBillTextBox.Text);
                data.TransportBill = GetDecimalValue(transportBillTextBox.Text);
                data.IncomeTax = GetDecimalValue(incomeTaxTextBox.Text);
                data.OthersDeduction = GetDecimalValue(othersDeductionTextBox.Text);
            }
        }

        private void LoadSelectedEmployeeData()
        {
            if (employeeSelectionComboBox.SelectedItem != null)
            {
                string? selectedText = employeeSelectionComboBox.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(selectedText))
                {
                    string employeeId = selectedText.Split(' ')[0]; // Get ID part
                    currentEmployeeId = employeeId;
                    
                    isLoading = true; // Prevent saving during loading
                    
                    if (employeeData.ContainsKey(employeeId))
                    {
                        var data = employeeData[employeeId];
                        
                        // Load allowances
                        houseRentAllowanceTextBox.Text = data.HouseRentAllowance == 0 ? "" : data.HouseRentAllowance.ToString("0.00");
                        medicalAllowanceTextBox.Text = data.MedicalAllowance == 0 ? "" : data.MedicalAllowance.ToString("0.00");
                        educationAllowanceTextBox.Text = data.EducationAllowance == 0 ? "" : data.EducationAllowance.ToString("0.00");
                        telephoneAllowanceTextBox.Text = data.TelephoneAllowance == 0 ? "" : data.TelephoneAllowance.ToString("0.00");
                        festivalBonusTextBox.Text = data.FestivalBonus == 0 ? "" : data.FestivalBonus.ToString("0.00");
                        transportAllowanceTextBox.Text = data.TransportAllowance == 0 ? "" : data.TransportAllowance.ToString("0.00");
                        othersAllowanceTextBox.Text = data.OthersAllowance == 0 ? "" : data.OthersAllowance.ToString("0.00");
                        
                        // Load deductions
                        gpfTextBox.Text = data.GPF == 0 ? "" : data.GPF.ToString("0.00");
                        houseRentDeductionTextBox.Text = data.HouseRentDeduction == 0 ? "" : data.HouseRentDeduction.ToString("0.00");
                        insurancePremiumTextBox.Text = data.InsurancePremium == 0 ? "" : data.InsurancePremium.ToString("0.00");
                        electricityBillTextBox.Text = data.ElectricityBill == 0 ? "" : data.ElectricityBill.ToString("0.00");
                        transportBillTextBox.Text = data.TransportBill == 0 ? "" : data.TransportBill.ToString("0.00");
                        incomeTaxTextBox.Text = data.IncomeTax == 0 ? "" : data.IncomeTax.ToString("0.00");
                        othersDeductionTextBox.Text = data.OthersDeduction == 0 ? "" : data.OthersDeduction.ToString("0.00");
                    }
                    else
                    {
                        // Clear all fields if no data found
                        ClearAllFields();
                    }
                    
                    isLoading = false; // Re-enable saving
                }
            }
        }

        private void ClearAllFields()
        {
            // Clear allowances
            houseRentAllowanceTextBox.Text = "";
            medicalAllowanceTextBox.Text = "";
            educationAllowanceTextBox.Text = "";
            telephoneAllowanceTextBox.Text = "";
            festivalBonusTextBox.Text = "";
            transportAllowanceTextBox.Text = "";
            othersAllowanceTextBox.Text = "";
            
            // Clear deductions
            gpfTextBox.Text = "";
            houseRentDeductionTextBox.Text = "";
            insurancePremiumTextBox.Text = "";
            electricityBillTextBox.Text = "";
            transportBillTextBox.Text = "";
            incomeTaxTextBox.Text = "";
            othersDeductionTextBox.Text = "";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string? month = monthComboBox.SelectedItem?.ToString();
            string year = yearTextBox.Text.Trim();
            string bonusText = bonusTextBox.Text.Trim();

            if (string.IsNullOrEmpty(month))
            {
                MessageBox.Show("Please select a month.", "Validation Error");
                return;
            }

            if (string.IsNullOrEmpty(year))
            {
                MessageBox.Show("Please enter a year.", "Validation Error");
                return;
            }

            if (!decimal.TryParse(bonusText, out decimal bonusPercentage))
            {
                MessageBox.Show("Please enter a valid bonus percentage.", "Validation Error");
                return;
            }

            ProcessSalaries(month, year, bonusPercentage);
        }

        private void ProcessSalaries(string month, string year, decimal bonusPercentage)
        {
            try
            {
                // Save current employee data before processing
                SaveCurrentEmployeeData();
                
                var employees = modifyFile.GetAllEmployees();
                
                string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?
                                 .Parent?.Parent?.Parent?.FullName ?? AppDomain.CurrentDomain.BaseDirectory;
                string salaryFilePath = Path.Combine(projectDir, "salary.txt");

                using (StreamWriter writer = new StreamWriter(salaryFilePath, true))
                {
                    // Write header
                    writer.WriteLine($"Month:{month} - Year:{year} - Bonus:{bonusPercentage:00}%");
                    writer.WriteLine("==================================================================================================================");

                    foreach (string employeeInfo in employees)
                    {
                        if (string.IsNullOrWhiteSpace(employeeInfo))
                            continue;

                        string[] employeeDetails = employeeInfo.Split(',');
                        if (employeeDetails.Length < 5) // Need at least ID, Name, Role, Position, Salary
                            continue;

                        string employeeId = employeeDetails[0].Trim();
                        string employeeName = employeeDetails[1].Trim();
                        
                        // The salary is in the 5th column (index 4)
                        if (!decimal.TryParse(employeeDetails[4].Trim(), out decimal baseSalary))
                            continue;

                        // Calculate salary components
                        decimal salaryAfterBonus = baseSalary + (baseSalary * bonusPercentage / 100);
                        
                        // Get employee-specific allowances and deductions
                        var empData = employeeData.ContainsKey(employeeId) ? employeeData[employeeId] : new EmployeeAllowancesDeductions();
                        
                        decimal totalAllowances = empData.HouseRentAllowance + empData.MedicalAllowance + empData.EducationAllowance + 
                                                empData.TelephoneAllowance + empData.FestivalBonus + empData.TransportAllowance + empData.OthersAllowance;
                        
                        decimal totalDeductions = empData.GPF + empData.HouseRentDeduction + empData.InsurancePremium + 
                                                empData.ElectricityBill + empData.TransportBill + empData.IncomeTax + empData.OthersDeduction;
                        
                        decimal finalSalary = salaryAfterBonus + totalAllowances - totalDeductions;

                        // Write employee details
                        writer.WriteLine($"Employee ID: {employeeId}");
                        writer.WriteLine($"Employee Name: {employeeName}");
                        writer.WriteLine($"Base Salary: {baseSalary:0.00}");
                        writer.WriteLine($"Salary after Bonus: {salaryAfterBonus:0.00}");
                        
                        // Write detailed allowances
                        writer.WriteLine("Allowances:");
                        writer.WriteLine($"  House Rent Allowance: {empData.HouseRentAllowance:0.00}");
                        writer.WriteLine($"  Medical Allowance: {empData.MedicalAllowance:0.00}");
                        writer.WriteLine($"  Education Allowance: {empData.EducationAllowance:0.00}");
                        writer.WriteLine($"  Telephone Allowance: {empData.TelephoneAllowance:0.00}");
                        writer.WriteLine($"  Festival Bonus: {empData.FestivalBonus:0.00}");
                        writer.WriteLine($"  Transport Allowance: {empData.TransportAllowance:0.00}");
                        writer.WriteLine($"  Others Allowance: {empData.OthersAllowance:0.00}");
                        writer.WriteLine($"  Total Allowances: {totalAllowances:0.00}");
                        
                        // Write detailed deductions
                        writer.WriteLine("Deductions:");
                        writer.WriteLine($"  GPF: {empData.GPF:0.00}");
                        writer.WriteLine($"  House Rent Deduction: {empData.HouseRentDeduction:0.00}");
                        writer.WriteLine($"  Insurance Premium: {empData.InsurancePremium:0.00}");
                        writer.WriteLine($"  Electricity Bill: {empData.ElectricityBill:0.00}");
                        writer.WriteLine($"  Transport Bill: {empData.TransportBill:0.00}");
                        writer.WriteLine($"  Income Tax: {empData.IncomeTax:0.00}");
                        writer.WriteLine($"  Others Deduction: {empData.OthersDeduction:0.00}");
                        writer.WriteLine($"  Total Deductions: {totalDeductions:0.00}");
                        
                        writer.WriteLine($"Final Salary: {finalSalary:0.00}");
                        writer.WriteLine("--------------------------------------------------");
                    }

                    // Add spacing for next month
                    writer.WriteLine();
                    writer.WriteLine();
                }

                MessageBox.Show($"Salary processing completed successfully!\nData saved to salary.txt", "Success");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing salaries: {ex.Message}", "Error");
            }
        }

        private decimal GetAllowancesTotal()
        {
            decimal total = 0;
            
            // Sum all allowance text boxes
            total += GetDecimalValue(houseRentAllowanceTextBox.Text);
            total += GetDecimalValue(medicalAllowanceTextBox.Text);
            total += GetDecimalValue(educationAllowanceTextBox.Text);
            total += GetDecimalValue(telephoneAllowanceTextBox.Text);
            total += GetDecimalValue(festivalBonusTextBox.Text);
            total += GetDecimalValue(transportAllowanceTextBox.Text);
            total += GetDecimalValue(othersAllowanceTextBox.Text);
            
            return total;
        }

        private decimal GetDeductionsTotal()
        {
            decimal total = 0;
            
            // Sum all deduction text boxes
            total += GetDecimalValue(gpfTextBox.Text);
            total += GetDecimalValue(houseRentDeductionTextBox.Text);
            total += GetDecimalValue(insurancePremiumTextBox.Text);
            total += GetDecimalValue(electricityBillTextBox.Text);
            total += GetDecimalValue(transportBillTextBox.Text);
            total += GetDecimalValue(incomeTaxTextBox.Text);
            total += GetDecimalValue(othersDeductionTextBox.Text);
            
            return total;
        }

        private decimal GetDecimalValue(string text)
        {
            if (decimal.TryParse(text, out decimal value))
                return value;
            return 0;
        }
    }
}
