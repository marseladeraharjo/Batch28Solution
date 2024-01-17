using QuizDay05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay05.Repository
{
    internal interface IEmployeeRepository
    {
        List<Employees> InitListEmployee();
        void Save(List<Employees> employees, Employees emp);
        void Update(List<Employees> employees, int empId, Employees updatedEmp);
        void Delete(List<Employees> employees, int empId);
        void FindAll(List<Employees> employees);
        Employees FindById(List<Employees> employees, int empId);
    }
}
