using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartThree
{
    internal class Programmer : Employee
    {
        private double transportasi;

        public Programmer(int empId, string fullName, DateTime joinDate, double basicSalary, double totalSalary, double transportasi) 
            : base(empId, fullName, joinDate, basicSalary, totalSalary)
        {
            this.transportasi = transportasi;
            TotalSalary = basicSalary + transportasi;
        }

        public double Transportasi { get => transportasi; set => transportasi = value; }
    }
}
