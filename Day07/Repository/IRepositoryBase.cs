using Day07.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07.Repository
{
    internal interface IRepositoryBase<T>
    {
        IEnumerable<T> FindAll();

        T FindById(long id);

        T Save(T entity);

        T Update(T entity);

        void Delete(T entity);
    }
}
