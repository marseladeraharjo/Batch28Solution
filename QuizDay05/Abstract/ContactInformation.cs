using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay05.Abstract
{
    internal abstract class ContactInformation : AddressInformation
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }

        public long Phone {  get; set; }
        public long? Fax { get; set; }
    }
}
