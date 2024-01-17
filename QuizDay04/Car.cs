using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay04
{
    internal class Car : Vehicle
    {
        private string noPolice;

        public Car(string noPolice,string vehicleType, int year, double price, double tax, int seat, DateTime transactionDate, double total) 
            : base(vehicleType, year, price, tax, seat, transactionDate, total)
        {
            this.noPolice = noPolice;
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public string NoPolice { get => noPolice; set => noPolice = value; }
    }
}
