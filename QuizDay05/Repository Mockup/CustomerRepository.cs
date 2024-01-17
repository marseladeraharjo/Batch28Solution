using QuizDay05.Models;
using QuizDay05.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay05.Repository_Mockup
{
    internal class CustomerRepository : Customers, ICustomerRepository
    {
        public void Delete(List<Customers> customers, string custId)
        {
            var deleted = FindById(customers, custId);
            customers.Remove(deleted);
        }

        public void FindAll(List<Customers> customers)
        {
            foreach (Customers cust  in customers)
            {
                Console.WriteLine(cust.ToString());
            }
        }

        public Customers FindById(List<Customers> customers, string custId)
        {
            var result = customers.Find(v => v.CustomerID == custId);
            return result;
        }

        public void Save(List<Customers> customers, Customers cust)
        {
            customers.Add(cust);
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
        public List<Customers> InitListCustomer()
        {
            var listCustomer  = new List<Customers>();

            Customers cust1 = new()
            {
                CustomerID = "ALFKI",
                CompanyName = "IKEA",
                ContactName = "Agus Setya",
                ContactTitle = "Sales Manager",
                Address = "Jl. Danau Buaya",
                City = "Sentul",
                Region = "Jawa Barat",
                PostalCode = 54171,
                Country = "Indonesia",
                Phone = 081801020311,
                Fax = 0300076545
            };

            listCustomer.Add(cust1);

            return listCustomer;
        }
    }
}
