using QuizDay05.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay05.Models
{
    internal class Customers : ContactInformation
    {
        public string CustomerID { get; set; }

        public override string? ToString()
        {
            return $"CustomerID : {CustomerID}\n" +
               $"CompanyName : {CompanyName}\n" +
               $"ContactName : {ContactName}\n" +
               $"ContactTitle : {ContactTitle}\n" +
               $"Address : {Address}\n" +
               $"City : {City}\n" +
               $"Region : {Region}\n" +
               $"PostalCode : {PostalCode}\n" +
               $"Country : {Country}\n" +
               $"Phone : {Phone}\n" +
               $"Fax : {Fax}\n";
        }
    }
}
