using Day06.DbContext;
using Day06.Entity;
using Day06.Repository;
using Microsoft.Extensions.Configuration;

namespace Day06
{
    internal class Program
    {
        private static IConfigurationRoot Configuration;

        static async Task Main(string[] args)
        {
            BuildConfiguration();
            var adoDbContext = new AdoDbContext(Configuration.GetConnectionString("NorthWindDS"));

            //var adoDbMongodbContext = new AdoDbContext(Configuration.GetConnectionString("NorthwindDS"));

            // Call repository interface, implement SOLID Dependency Inversion
            //IRepository repositoryDB = new RepositoryDB(adoDbContext);

            // 1. Call method di interface, FindAll return IEnumerator, untuk mendapatkan value harus di loop dulu
            /*var employees = repositoryDB.FindAll();

            while (employees.MoveNext())
            {
                var employee = employees.Current;
                Console.WriteLine(employee.ToString());
            }*/


            // 2. FindAllEmployee() return IEnumerable langsung dapat di loop using foreach
            /*Console.WriteLine("Show all employee");
            var emps = repositoryDB.FindAllEmployee();
            foreach (var employee in emps)
            {
                Console.WriteLine(employee.ToString());
            }*/

            /*Console.WriteLine("Show all customer");
            var cust = repositoryDB.FindAllCustomer();
            foreach (var customer in cust)
            {
                Console.WriteLine(customer.ToString());
            }

            Console.WriteLine("Show all supplier");
            var supp = repositoryDB.FindAllSupplier();
            foreach (var supplier in supp)
            {
                Console.WriteLine(supplier.ToString());
            }*/


            // 3. FindEmployeeById
            /* var foundEmployee = repositoryDB.FindEmployeeById(2);
             Console.WriteLine($"Found Employee : {foundEmployee}");

             var foundSupplier = repositoryDB.FindSupplierById(2);
             Console.WriteLine($"Found Supplier : {foundSupplier}");


             // 4. FindEmployeeByFirstName
             var filterEmpByName = repositoryDB.FindEmployeeByFirstName("A%");
             foreach (var employee in filterEmpByName)
             {
                 Console.WriteLine(employee.ToString());
             }

             var filterSuppByCompName = repositoryDB.FindSupplierByCompanyName("Mayumi's");
             foreach (var supplier in filterSuppByCompName)
             {
                 Console.WriteLine(supplier.ToString());
             }*/


            // 5. CreateEmployee, EmployeeId tidak diisi, otomatis dari sequence database
            /*var newEmps = new Employee
            {
                FirstName = "Yuli",
                LastName = "Ayu",
                BirthDate = DateTime.Now
            };

            newEmps = repositoryDB.CreateEmployee(ref newEmps);
            Console.WriteLine(newEmps.ToString());

            var newSupp = new Suppliers
            {
                CompanyName = "IKEA",
                ContactName = "Marsel",
                ContactTitle = "Sales Manager",
                HomePage = "#FORMAGGI.HTM#"
            };

            newSupp = repositoryDB.CreateSupplier(ref newSupp);
            Console.WriteLine(newSupp.ToString());*/


            // 6. Update Employee
            /*var findUpdateEmps = new Employee
            {
                EmployeeId = 11,
                FirstName = "Widi",
                LastName = "Wini",
                BirthDate = DateTime.Now
            };

            var updateEmp = repositoryDB.UpdateEmployee(findUpdateEmps);
            Console.WriteLine(updateEmp.ToString());

            var findUpdateSupp = new Suppliers
            {
                SupplierId = 6,
                CompanyName = "Mayumi's",
                ContactName = "M. Ohno",
                ContactTitle = "Marketing Representative",
                HomePage = "Mayumi's (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/mayumi.htm#"
            };

            var updateSupp = repositoryDB.UpdateSupplier(findUpdateSupp);
            Console.WriteLine(updateSupp.ToString());*/


            // 7. Delete Employee
            //repositoryDB.DeleteEmployee(10);

            /*repositoryDB.DeleteSupplier(6);*/

            // 8.  Call Async Method
            /*var employeesAsync = repositoryDB.FindAllEmployeeAsync();
            foreach(var item in await employeesAsync)
            {
                Console.WriteLine($"{item.ToString()}");
            }*/

            // 9. Call generic method
            /*IRepositoryBase<Employee> employeeRepository = new EmployeeRepository(adoDbContext);
            Console.WriteLine("Show all employee");
            var empGeneric = employeeRepository.FindAll<Employee>();
            foreach (var employee in empGeneric)
            {
                Console.WriteLine($"{employee.ToString()}");
            }*/

            await Console.Out.WriteLineAsync("Show all customer");
            IRepositoryBase<Customers> iRepoCust = new CustomerRepository(adoDbContext);
            var customers = iRepoCust.FindAll();
            foreach(var customer in customers)
            {
                await Console.Out.WriteLineAsync($"{customer.ToString()}");
            }

            await Console.Out.WriteLineAsync("Show all employee");
            IRepositoryBase<Employee> iRepoEmp = new EmployeeRepository(adoDbContext);
            var employees = iRepoEmp.FindAll();
            foreach(var employee in employees)
            {
                await Console.Out.WriteLineAsync($"{employee.ToString()}");
            }


        }

        private static void BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            //Console.WriteLine(Configuration.GetConnectionString("NorthWindDS"));
        }
    }
}
