using QuizDay05.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay05.Models
{
    internal class Employees : AddressInformation
    {
        public int EmployeeID {  get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public long HomePhone { get; set; }
        public int Extension { get; set; }
        public string Photo {  get; set; }
        public string Notes { get; set; }
        public int ReportsTo { get; set; }
        public string PhotoPath { get; set; }

        public override string? ToString()
        {
            return $"EmpId : {EmployeeID}\n" +
                $"LastName : {LastName}\n" + 
                $"FirstName : {FirstName}\n" +
                $"Title : {Title}\n" +
                $"TOC : {TitleOfCourtesy}\n" +
                $"BirthDate : {BirthDate}\n" +
                $"HireDate : {HireDate}\n" + 
                $"Address : {Address}\n" +
                $"City : {City}\n" + 
                $"Region : {Region}\n" +
                $"PostalCode : {PostalCode}\n" +
                $"Country : {Country}\n" +
                $"HomePhone : {HomePhone}\n" +
                $"Extension : {Extension}\n" +
                $"Photo : {Photo}\n" +
                $"Notes : {Notes}\n" +
                $"ReportsTo : {ReportsTo}\n" +
                $"PhotoPath : {PhotoPath}\n";
        }
    }
}
