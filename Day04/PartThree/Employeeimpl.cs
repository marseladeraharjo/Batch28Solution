using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartThree
{
    internal class Employeeimpl : IEmployee
    {
        public void DisplayEmployee(List<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        public List<Employee> FindByEmpId(List<Employee> employees, int empId)
        {
            return employees.FindAll(v => v.EmpId == empId);
        }

        public double GetTotalSalary(List<Employee> employees)
        {
            var total= 0.0;

            foreach (Employee emp in employees)
            {
                total += emp.TotalSalary;
            }

            return total;
        }

        public List<Employee> InitListEmployee()
        {
            var listEmployee = new List<Employee>();

            Employee emp1 = new Employee();

            emp1.FullName = "Test";
            emp1.EmpId = 1;
            emp1.JoinDate = DateTime.Now;
            emp1.BasicSalary = 5_500;

            // 2. Implement argument constructor params
            Employee emp2 = new Employee(2, "Kang dian", new DateTime(), 4_500, 0);

            // Create object programmer
            Programmer programmer1 = new Programmer(3, "Yuli", DateTime.Now, 6_000, 0, 500);
            

            // Create object sales
            Sales sales1 = new Sales(4, "Widi", DateTime.Now, 7_000, 0, 100, 150);

            listEmployee.Add(emp1);
            listEmployee.Add(emp2);

            listEmployee.Add(programmer1);

            listEmployee.Add(sales1);

            return listEmployee;
        }
    }
}
