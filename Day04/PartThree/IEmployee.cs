using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartThree
{
    internal interface IEmployee
    {
        List<Employee> InitListEmployee();

        public void DisplayEmployee(List<Employee> employees);

        double GetTotalSalary(List<Employee> employees);

        List<Employee> FindByEmpId(List<Employee> employees, int empId);
    }
}
