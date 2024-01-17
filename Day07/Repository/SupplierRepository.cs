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
            /*SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "select SupplierId, CompanyName, ContactName, ContactTitle from Suppliers;",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] { }
            };*/

            var sql = "select SupplierId, CompanyName, ContactName, ContactTitle from Suppliers;";

            var dataSet = _dapperDbContext.ExecuteReader<Supplier>(sql);

            while (dataSet.MoveNext())
            {
                var item = dataSet.Current;
                yield return item;
            }

            _dapperDbContext.Dispose();
        }

        public override IEnumerable<Supplier> FindById(long id)
        {
            /*SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "select SupplierId, CompanyName, ContactName, ContactTitle from Suppliers where SupplierID = @suppId",
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
            };*/
            var param = id;

            var sql = $"select SupplierId, CompanyName, ContactName, ContactTitle from Suppliers where SupplierID = {param};";

            var dataSet = _dapperDbContext.ExecuteReader<Supplier>(sql);

            while (dataSet.MoveNext())
            {
                var item = dataSet.Current;
                yield return item;
            }

            _dapperDbContext.Dispose();
        }
    }
}
