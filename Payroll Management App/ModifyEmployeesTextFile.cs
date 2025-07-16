using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Management_App
{
    internal class ModifyEmployeesTextFile
    {
        public void AddNewEmployee(string name, string dateOfBirth, string designation, 
            string presentAddress, string permanentAddress, string salary, string phone, string gender)
        {
            string employeeInfo = name + "," +designation + "," + salary + "," + phone + "," + presentAddress + "," + permanentAddress  + "," + dateOfBirth + "," + gender;

            // প্রজেক্ট এর মেইন ডিরেক্টরি খোজার জন্য
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
                             .Parent.Parent.Parent.FullName;

            //প্রজেক্ট এর মেইন ডিরেক্টরিতে employees.txt ফাইল কে খোজার জন্য, ফাইল আগে থেকে না থাকলে নিজে নিজে create হবে 
            string filePath = Path.Combine(projectDir, "employees.txt");

            File.AppendAllText(filePath, employeeInfo);
        }

        public List<string> GetAllEmployees()
        {
            // প্রজেক্ট এর মেইন ডিরেক্টরি খোজার জন্য
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
                             .Parent.Parent.Parent.FullName;

            //প্রজেক্ট এর মেইন ডিরেক্টরিতে employees.txt ফাইল কে খোজার জন্য
            string filePath = Path.Combine(projectDir, "employees.txt");

            if (!File.Exists(filePath))
            {
                return new List<string>(); // যদি ফাইল না থাকে, তাহলে খালি লিস্ট রিটার্ন করবে
            }

            List<String> employeeInfoList =  File.ReadAllLines(filePath).ToList(); // ফাইল থেকে সব লাইন পড়বে এবং লিস্টে রিটার্ন করবে

            return employeeInfoList;
        }
    }
}
