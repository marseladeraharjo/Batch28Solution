using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay04
{
    internal class SUV : Car
    {
        private double rent;
        private double driverCost;

        public static int totalSUV = 0;

        public SUV(string noPolice, string vehicleType, int year, double price, double tax, int seat, DateTime transactionDate, double rent, double driverCost, double total) 
            : base(noPolice, vehicleType, year, price, tax, seat, transactionDate, total)
        {
            this.rent = rent;
            this.driverCost = driverCost;
            Total = rent + driverCost;
            totalSUV++;
        }

        public override string? ToString()
        {
            return $"NoPolice : {NoPolice}, Vehicle Type : {VehicleType}, Year : {Year}, Price : {Price}, Tax : {Tax}, Seat : {Seat}, " +
               $"TransactionDate : {TransactionDate},  Rent : {Rent}, Driver : {DriverCost}, Total : {Total}";
        }

        public double Rent { get => rent; set => rent = value; }
        public double DriverCost { get => driverCost; set => driverCost = value; }
    }
}
