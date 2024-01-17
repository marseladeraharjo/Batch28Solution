using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay05.Abstract
{
    internal abstract class AddressInformation
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string? Region { get; set; }
        public long? PostalCode { get; set; }
        public string Country { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
