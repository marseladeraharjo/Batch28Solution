using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class Employee
    {
        // inisiasi langsung dengan method nya
        public long EmpId { get; set; }
        public string? FullName { get; set; }

        public override string? ToString()
        {
            return $"EmpId : {EmpId}, FullName : {FullName}";
        }
    }
}
