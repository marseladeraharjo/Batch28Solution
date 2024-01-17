using Day07.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07.Repository
{
    internal abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly DapperDbContext _dapperDbContext;

        // Inject with dapper
        public RepositoryBase(DapperDbContext dapperDbContext)
        {
            _dapperDbContext = dapperDbContext;
        }
        public virtual void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> FindById(long id)
        {
            throw new NotImplementedException();
        }
        public virtual T Save(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
