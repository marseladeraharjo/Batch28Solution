using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class Owner : Person
    {
        private int hasCompany;

        public Owner(string fullName, string npwp, int hasCompany) : base(fullName, npwp)
        {
            this.hasCompany = hasCompany;
        }

        public int HasCompany { get => hasCompany; set => hasCompany = value; }
    }
}
