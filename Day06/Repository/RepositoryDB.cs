using Day06.DbContext;
using Day06.Entity;
using Northwind.Persistence.RepositoryContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Repository
{
    internal class RepositoryDB : IRepository
    {
        private readonly AdoDbContext _adoDbContext;
        public RepositoryDB(AdoDbContext adoDbContext)
        {
            _adoDbContext = adoDbContext;
        }

        public Employee CreateEmployee(ref Employee employee)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "insert into employees (LastName,FirstName,BirthDate) values (@lastName,@firstName,@birthDate);",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel()
                    {
                        ParameterName = "@empId",
                        DataType = DbType.Int32,
                        Value = employee.EmployeeId
                    },
                    new SqlCommandParameterModel()
                    {
                        ParameterName = "@lastName",
                        DataType = DbType.String,
                        Value = employee.LastName
                    },
                    new SqlCommandParameterModel()
                    {
                        ParameterName = "@firstName",
                        DataType = DbType.String,
                        Value = employee.FirstName
                    },
                    new SqlCommandParameterModel()
                    {
                        ParameterName = "@birthDate",
                        DataType = DbType.DateTime,
                        Value = employee.BirthDate
                    }
                }
            };

            _adoDbContext.ExecuteNonQuery( model );
            _adoDbContext.Dispose();

            return employee;
        }

        public void DeleteEmployee(long id)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "DELETE FROM employees WHERE employeeId=@empId;",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel()
                    {
                        ParameterName = "@empId",
                        DataType = DbType.Int64,
                        Value = id
                    }
                }
            };

            _adoDbContext.ExecuteNonQuery( model );
            _adoDbContext.Dispose();
        }

        public IEnumerator<Employee> FindAll()
        {
            IEnumerator<Employee> dataSet = _adoDbContext
                .ExecuteReader<Employee>("select EmployeeId, LastName, FirstName, BirthDate from Employees;");

            _adoDbContext.Dispose();
            return dataSet;
        }

       

        public IEnumerable<Employee> FindAllEmployee()
        {
            IEnumerator<Employee> dataSet = _adoDbContext
                .ExecuteReader<Employee>("select EmployeeId, LastName, FirstName, BirthDate from Employees;");

            _adoDbContext.Dispose();

            while (dataSet.MoveNext())
            {
                var employee = dataSet.Current;
                yield return employee;
            }
        }

        public async Task<IEnumerable<Employee>> FindAllEmployeeAsync()
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "select EmployeeId, LastName, FirstName, BirthDate from Employees;",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[]{}
            };

            var dataSet = _adoDbContext.ExecuteReaderAsync<Employee>(model);

            var employees = new List<Employee>();

            while (await dataSet.MoveNextAsync())
            {
                //var employee = dataSet.Current;
                employees.Add(dataSet.Current);
                //yield return employee;
            }

            _adoDbContext.Dispose();

            return employees;
        }

        public async IAsyncEnumerable<Employee> FindAllEmployeeIAsync()
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "select EmployeeId, LastName, FirstName, BirthDate from Employees;",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] { }
            };

            var dataSet = _adoDbContext.ExecuteReaderAsync<Employee>(model);

            //var employees = new List<Employee>();

            while (await dataSet.MoveNextAsync())
            {
                var employee = dataSet.Current;
                //employees.Add(dataSet.Current);
                yield return employee;
            }

            _adoDbContext.Dispose();
        }

        public IEnumerable<Employee> FindEmployeeByFirstName(string firstName)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "select EmployeeId, LastName, FirstName, BirthDate from Employees where FirstName like @firstName;",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel()
                    {
                        ParameterName = "@firstName",
                        DataType = DbType.String,
                        Value = firstName
                    }
                }
            };

            var dataSet = _adoDbContext.ExecuteReader<Employee>(model);

            while (dataSet.MoveNext())
            {
                var employee = dataSet.Current;
                yield return employee;
            }

            _adoDbContext.Dispose();
        }

        public Employee FindEmployeeById(long id)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "select EmployeeId, LastName, FirstName, BirthDate from Employees where EmployeeId=@empId;",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel()
                    {
                        ParameterName = "@empId",
                        DataType = DbType.Int64,
                        Value = id
                    }
                }
            };

            var dataset = _adoDbContext.ExecuteReader<Employee>(model);

            var employee = new Employee();

            while (dataset.MoveNext())
            {
                employee = dataset.Current;
            }

            _adoDbContext.Dispose();

            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "UPDATE Employees SET FirstName=@firstName WHERE employeeId = @empId;",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel()
                    {
                        ParameterName = "@firstName",
                        DataType = DbType.String,
                        Value = employee.FirstName
                    },
                    new SqlCommandParameterModel()
                    {
                        ParameterName = "@empId",
                        DataType = DbType.Int64,
                        Value = employee.EmployeeId
                    }
                }
            };

            _adoDbContext.ExecuteNonQuery(model);
            _adoDbContext.Dispose();
            return employee;
        }
    }
}
