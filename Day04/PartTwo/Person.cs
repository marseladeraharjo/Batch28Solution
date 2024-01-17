using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal abstract class Person
    {
        private string fullName;
        private string npwp;

        protected Person(string fullName, string npwp)
        {
            this.fullName = fullName;
            this.npwp = npwp;
        }

        public override string? ToString()
        {
            return $"FullName : {fullName}, npwp : {npwp}";
        }
    }
}
