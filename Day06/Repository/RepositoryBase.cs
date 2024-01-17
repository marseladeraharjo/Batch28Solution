using Day06.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Repository
{
    internal abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly AdoDbContext _adoDbContext;

        // Inject with adbcontext
        public RepositoryBase(AdoDbContext adoDbContext)
        {
            _adoDbContext = adoDbContext;
        }

        public virtual void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> FindById()
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
