using QuizDay05.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay05.Models
{
    internal class Suppliers : ContactInformation
    {
        public int SupplierID { get; set; }
        public string? HomePage { get; set; }
    }
}
