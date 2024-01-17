using QuizDay05.Models;
using QuizDay05.Repository;
using QuizDay05.Repository_Mockup;

namespace QuizDay05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Employee Class
            IEmployeeRepository employeeRepository = new EmployeeRepository();

            var listEmployees = employeeRepository.InitListEmployee();

            Employees emp2 = new()
            {
                EmployeeID = 2,
                LastName = "Aditya",
                FirstName = "Julian",
                Title = "Sales Manager",
                TitleOfCourtesy = "Mr.",
                BirthDate = DateTime.Now,
                HireDate = DateTime.Now,
                Address = "Jl. Sawangan",
                City = "Depok",
                Region = "Jawa Barat",
                PostalCode = 54123,
                Country = "Indonesia",
                HomePhone = 081801020305,
                Extension = 1234,
                Photo = "0x151C2F00020000000D000E00140",
                Notes = "Julian is a smart person",
                ReportsTo = 2,
                PhotoPath = "http://accweb/emmployees/davolio.bmp"
            };

            Employees emp3 = new()
            {
                EmployeeID = 3,
                LastName = "Affila",
                FirstName = "Pratama",
                Title = "IT Specialist",
                TitleOfCourtesy = "Mr.",
                BirthDate = DateTime.Now,
                HireDate = DateTime.Now,
                Address = "Jl. Danau Anggrek",
                City = "Tangerang Selatan",
                Region = "Banten",
                PostalCode = 54161,
                Country = "Indonesia",
                HomePhone = 081801020306,
                Extension = 1234,
                Photo = "0x151C2F00020000000D000E00140",
                Notes = "Tama is a cool person",
                ReportsTo = 2,
                PhotoPath = "http://accweb/emmployees/davolio.bmp"
            };

            employeeRepository.Save(listEmployees, emp2);
            employeeRepository.Save(listEmployees, emp3);

            foreach (var employee in listEmployees)
            {
                Console.WriteLine(employee.ToString());
            }

            Console.WriteLine("Update");
            int updtId = 2;
            Employees updtEmp = new Employees { LastName = "Sakti" };

            employeeRepository.Update(listEmployees, updtId, updtEmp);

            Console.WriteLine("Delete");
            int delId = 1;
            employeeRepository.Delete(listEmployees, delId);

            foreach (var employee in listEmployees)
            {
                Console.WriteLine(employee.ToString());
            }

            int findID = 2;
            Console.WriteLine($"Find by ID : {findID}");
            var findResult = employeeRepository.FindById(listEmployees, findID);
            Console.WriteLine(findResult.ToString());

            Console.WriteLine("Find All");
            employeeRepository.FindAll(listEmployees);


            // Customer Class
            /*ICustomerRepository customerRepository = new CustomerRepository();

            var listCustomers = customerRepository.InitListCustomer();


            Customers cust2 = new()
            {
                CustomerID = "ANATR",
                CompanyName = "Ramayana",
                ContactName = "Iqbal Adi",
                ContactTitle = "Sales Manager",
                Address = "Jl. Buaya Darat",
                City = "Bogor",
                Region = "Jawa Barat",
                PostalCode = 54141,
                Country = "Indonesia",
                Phone = 081801020245,
                Fax = 0300076789
            };

            Customers cust3 = new()
            {
                CustomerID = "BERGS",
                CompanyName = "Miniso",
                ContactName = "Uchiha Sasuke",
                ContactTitle = "Sales Manager",
                Address = "Jl. Danau Buaya",
                City = "Sentul",
                Region = "Jawa Barat",
                PostalCode = 54171,
                Country = "Indonesia",
                Phone = 081801020222,
                Fax = 0300076222
            };

            customerRepository.Save(listCustomers, cust2);
            customerRepository.Save(listCustomers, cust3);

            foreach (var customer in listCustomers)
            {
                Console.WriteLine(customer.ToString());
            }

            Console.WriteLine("Delete");
            string delId = "ALFKI";
            customerRepository.Delete(listCustomers, delId);

            foreach (var customers in listCustomers)
            {
                Console.WriteLine(customers.ToString());
            }

            string findID = "ANATR";
            Console.WriteLine($"Find by ID : {findID}");
            var findResult = customerRepository.FindById(listCustomers, findID);
            Console.WriteLine(findResult.ToString());

            Console.WriteLine("Find All");
            customerRepository.FindAll(listCustomers);*/

        }
    }
}