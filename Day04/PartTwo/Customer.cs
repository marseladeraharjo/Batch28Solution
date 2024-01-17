using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class Customer : Person
    {
        private string accountNumber;

        public Customer(string fullName, string npwp, string accountNumber) : base(fullName, npwp)
        {
            this.accountNumber = accountNumber;
        }

        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
    }
}
