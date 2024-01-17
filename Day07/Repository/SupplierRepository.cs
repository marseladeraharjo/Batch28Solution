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
            var sql = "select SupplierId, CompanyName, ContactName, ContactTitle, HomePage from Suppliers;";

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

        public override Supplier Save(ref Supplier supplier)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "insert into Suppliers (CompanyName,ContactName,ContactTitle,HomePage) values (@companyName,@contactName,@contactTitle,@homePage);",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {
                    new SqlCommandParameterModel() {
                        ParameterName = "@suppId",
                        DataType = DbType.Int64,
                        Value = supplier.SupplierId
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@companyName",
                        DataType = DbType.String,
                        Value = supplier.CompanyName
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@contactName",
                        DataType = DbType.String,
                        Value = supplier.ContactName
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@contactTitle",
                        DataType = DbType.String,
                        Value = supplier.ContactTitle
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@homePage",
                        DataType = DbType.String,
                        Value = supplier.HomePage
                    }
                }
            };

            _dapperDbContext.ExecuteNonQuery(model);
            _dapperDbContext.Dispose();

            return supplier;
        }

        public override void Delete(long id)
        {
            var sql = $"DELETE FROM Suppliers WHERE SupplierID={id}";

            _dapperDbContext.ExecuteNonQuery(sql);
            _dapperDbContext.Dispose();
        }

        public override Supplier Update(Supplier entity)
        {
            return base.Update(entity);
        }
    }
}
