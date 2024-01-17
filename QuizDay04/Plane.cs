using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay04
{
    internal class Plane : Vehicle
    {
        private string noRegister;

        public Plane(string noRegister,string vehicleType, int year, double price, double tax, int seat, DateTime transactionDate, double total) 
            : base(vehicleType, year, price, tax, seat, transactionDate, total)
        {
            this.noRegister = noRegister;
        }
        public override string? ToString()
        {
            return base.ToString();
        }

        public string NoRegister { get => noRegister; set => noRegister = value; }
    }
}
