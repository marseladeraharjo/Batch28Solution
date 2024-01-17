using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay04
{
    internal class Taxi : Car
    {
        private int orderKM;
        private double orderCost;

        public Taxi(string noPolice, string vehicleType, int year, double price, double tax, int seat, DateTime transactionDate, int orderKM, double orderCost, double total) 
            : base(noPolice, vehicleType, year, price, tax, seat, transactionDate, total)
        {
            this.orderKM = orderKM;
            this.orderCost = orderCost;
            Total = orderKM * orderCost;
        }

        public override string? ToString()
        {
            return $"NoPolice : {NoPolice}, Vehicle Type : {VehicleType}, Year : {Year}, Price : {Price}, Tax : {Tax}, Seat : {Seat}, " +
               $"TransactionDate : {TransactionDate},  Order : {OrderKM}, OrderPerKM : {OrderCost}, Total : {Total}";
        }

        public int OrderKM { get => orderKM; set => orderKM = value; }
        public double OrderCost { get => orderCost; set => orderCost = value; }
    }
}
