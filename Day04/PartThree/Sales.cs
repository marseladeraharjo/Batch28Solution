using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartThree
{
    internal class Sales : Employee
    {
        public Sales(int empId, string fullName, DateTime joinDate, double basicSalary, double totalSalary,
            double bonus, double commission) 
            : base(empId, fullName, joinDate, basicSalary, totalSalary)
        {
            TotalSalary = basicSalary + bonus + commission;
        }

        public double Bonus { get; set; }
        public double Commission { get; set; }

        
    }
}
