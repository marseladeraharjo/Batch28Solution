//using Day04.PartOne;
using Day04.PartThree;
//using Day04.PartTwo;

namespace Day04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Use PartOne
            /*// 1. Create employee object
            Employee emp1 = new Employee();

            emp1.FullName = "Test";
            emp1.EmpId = 1;
            emp1.JoinDate = DateTime.Now;
            emp1.BasicSalary = 5_500;


            // 2. Implement argument constructor params
            Employee emp2 = new Employee(2,"Kang dian",new DateTime(),4_500, 0);

            var listEmployee = new List<Employee>();
            listEmployee.Add(emp1);
            listEmployee.Add(emp2);

            // Create object programmer
            Programmer programmer1 = new Programmer(3,"Yuli",DateTime.Now,6_000,0,500);
            // Polymorphism
            listEmployee.Add(programmer1);

            // Create object sales
            Sales sales1 = new Sales(4, "Widi", DateTime.Now, 7_000, 0, 100, 150);
            listEmployee.Add(sales1);

            foreach (Employee emp in listEmployee)
            {
                Console.WriteLine(emp.ToString());
            }

            Console.WriteLine($"Total Employee : {Employee.totalEmployee}");*/

            // Use PartTwo
            /*Employee emp1 = new Employee(1, "Kang dian", "123981");
            Customer cust = new Customer("PT. Code", "12121", "12121");
            Owner owner1 = new Owner("Aponk", "123456", 10);*/

            // Use PartThree
            // Call interface and implementation
            IEmployee employeeInf = new Employeeimpl();

            var listEmps =  employeeInf.InitListEmployee();

            employeeInf.DisplayEmployee(listEmps);

            var totalSalary = employeeInf.GetTotalSalary(listEmps);
            Console.WriteLine($"Total Salary : {totalSalary}");

            var result = employeeInf.FindByEmpId(listEmps, 4);
            employeeInf.DisplayEmployee(result);
        }
    }
}
