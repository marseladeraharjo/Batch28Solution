using Day06.DbContext;
using Day07.DbContext;
using Day07.Entity;
using Northwind.Persistence.RepositoryContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07.Repository
{
    internal class SupplierRepository : RepositoryBase<Supplier>
    {
        public SupplierRepository(DapperDbContext dapperDbContext) : base(dapperDbContext)
        {
        }

        public override IEnumerable<Supplier> FindAll()
        {
            var sql = "select SupplierId, CompanyName, ContactName, ContactTitle from Suppliers;";

            var dataSet = _dapperDbContext.ExecuteReader<Supplier>(sql);

            while (dataSet.MoveNext())
            {
                var item = dataSet.Current;
                yield return item;
            }

            _dapperDbContext.Dispose();
        }

        public override Supplier FindById(long id)
        {
            var param = id;

            var sql = $"select SupplierId, CompanyName, ContactName, ContactTitle from Suppliers where SupplierID = {param};";

            var dataSet = _dapperDbContext.ExecuteReader<Supplier>(sql);

            var supplier = new Supplier();

            while (dataSet.MoveNext())
            {
                supplier = dataSet.Current;
                
            }

            _dapperDbContext.Dispose();

            return supplier;
        }
    }
}
