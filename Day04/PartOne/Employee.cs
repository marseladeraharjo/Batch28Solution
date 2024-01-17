using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartOne
{
    internal class Employee
    {
        // Encapsulation instance attribute
        private int empId;
        private string fullName;
        private DateTime joinDate;
        private double basicSalary;
        private double totalSalary;

        // Static attribute
        public static int totalEmployee = 0;

        // Default constructor
        public Employee()
        {
            totalEmployee++;
        }

        // Parameter constructor
        public Employee(int empId, string fullName, DateTime joinDate, double basicSalary, double totalSalary)
        {
            this.empId = empId;
            this.fullName = fullName;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            this.totalSalary = totalSalary;
            totalEmployee++;
        }

        public override string? ToString()
        {
            return $"EmpId : {EmpId}, FullName : {FullName}, JoinDate : {JoinDate}, Salary : {BasicSalary}, TotalSalary : {TotalSalary}";
        }

        // get set
        public int EmpId { get => empId; set => empId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }
        public double TotalSalary { get => totalSalary; set => totalSalary = value; }
    }
}
