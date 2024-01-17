using Day06.DbContext;
using Day06.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Northwind.Persistence.RepositoryContext;

namespace Day06.Repository
{
    internal class CustomerRepository : RepositoryBase<Customers>, ICustomer
    {
        public CustomerRepository(AdoDbContext adoDbContext) : base(adoDbContext)
        {
        }

        public double CalculateIncome(List<Customers> customers)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Customers> FindAll()
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "select CustomerId,CompanyName,ContactName,ContactTitle from Customers;",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] { }
            };

            var dataSet = _adoDbContext.ExecuteReader<Customers>(model);

            while (dataSet.MoveNext())
            {
                var item = dataSet.Current;
                yield return item;
            }

            _adoDbContext.Dispose();
        }
    }
}
