
using QuizDay05.Models;
using QuizDay05.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay05.Repository_Mockup
{
    internal class EmployeeRepository : Employees, IEmployeeRepository
    {
        public void Delete(List<Employees> employees, int empId)
        {
            var deleted = FindById(employees, empId);
            employees.Remove(deleted);
        }

        public void FindAll(List<Employees> employees)
        {
            foreach (Employees emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        public Employees FindById(List<Employees> employees, int empId)
        {
            var result = employees.Find(v => v.EmployeeID == empId);
            return result;
        }

        public void Save(List<Employees> employees, Employees emp )
        {
            employees.Add(emp);
        }

        public void Update(List<Employees> employees, int empId, Employees updatedEmp)
        {
            Employees employeeToUpdate = employees.Find(v => v.EmployeeID == empId);
            if(employeeToUpdate != null)
            {
                employeeToUpdate.LastName = updatedEmp.LastName;
            }
        }

        public List<Employees> InitListEmployee()
        {
            var listEmployee = new List<Employees>();

            Employees emp1 = new() 
            { 
                EmployeeID = 1, 
                LastName = "Adenito",
                FirstName = "Marsel",
                Title = "Sales Manager",
                TitleOfCourtesy = "Mr.",
                BirthDate = DateTime.Now,
                HireDate = DateTime.Now,
                Address = "Jl. Danau Limboto",
                City = "Sentul",
                Region = "Jawa Barat", 
                PostalCode = 54121,
                Country = "Indonesia",
                HomePhone = 081801020304,
                Extension = 1234,
                Photo = "0x151C2F00020000000D000E00140",
                Notes = "Marsel is a lazy person",
                ReportsTo = 2,
                PhotoPath = "http://accweb/emmployees/davolio.bmp"
            };

            listEmployee.Add(emp1);

            return listEmployee;
        }
    }
}
