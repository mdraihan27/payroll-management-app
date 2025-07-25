using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Management_App
{
    internal class ModifyEmployeesTextFile
    {
        public void AddNewEmployee(string name, string dateOfBirth, string employeeType, string designation,
            string presentAddress, string permanentAddress, string salary, string phone, string gender)
        {
            string employeeId = GenerateEmployeeId();
            string employeeInfo = employeeId + "," + name + ","+employeeType+"," + designation + "," + salary + "," + phone + "," + presentAddress + "," + permanentAddress + "," + dateOfBirth + "," + gender;

            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?
                             .Parent?.Parent?.Parent?.FullName ?? AppDomain.CurrentDomain.BaseDirectory;

            string filePath = Path.Combine(projectDir, "employees.txt");

            File.AppendAllText(filePath, employeeInfo + Environment.NewLine);
        }

        private string GenerateEmployeeId()
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

        public void RemoveEmployees(List<string> employeeIds)
        {
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?
                             .Parent?.Parent?.Parent?.FullName ?? AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(projectDir, "employees.txt");

            if (!File.Exists(filePath))
                return;

            var lines = File.ReadAllLines(filePath).ToList();
            var filteredLines = lines.Where(line =>
            {
                if (string.IsNullOrWhiteSpace(line))
                    return false;
                var parts = line.Split(',');
                return parts.Length > 0 && !employeeIds.Contains(parts[0]);
            }).ToList();

            File.WriteAllLines(filePath, filteredLines);
        }

        public List<string> GetAllEmployees()
        {
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?
                             .Parent?.Parent?.Parent?.FullName ?? AppDomain.CurrentDomain.BaseDirectory;

            string filePath = Path.Combine(projectDir, "employees.txt");

            if (!File.Exists(filePath))
            {
                return new List<string>();
            }

            List<String> employeeInfoList = File.ReadAllLines(filePath).ToList();

            return employeeInfoList;
        }
    }
}
