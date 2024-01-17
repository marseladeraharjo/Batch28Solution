using QuizDay05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay05.Repository
{
    internal interface ICustomerRepository
    {
        List<Customers> InitListCustomer();
        void Save(List<Customers> customers, Customers cust);
        void Update(int id);
        void Delete(List<Customers> customers, string custId);
        void FindAll(List<Customers> customers);
        Customers FindById(List<Customers> customers, string custId);
    }
}
