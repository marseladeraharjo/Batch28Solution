using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay04
{
    internal class PrivateJet : Plane
    {
        private double rent;
        private double orderPerHours;
        private double driverCost;

        public PrivateJet(string noRegister, string vehicleType, int year, double price, double tax, int seat, DateTime transactionDate, double rent, double orderPerHours, double driverCost, double total) 
            : base(noRegister, vehicleType, year, price, tax, seat, transactionDate, total)
        {
            this.rent = rent;
            this.orderPerHours = orderPerHours;
            this.driverCost = driverCost;
            Total = rent + driverCost;
        }

        public override string? ToString()
        {
            return $"NoRegister : {NoRegister}, Vehicle Type : {VehicleType}, Year : {Year}, Price : {Price}, Tax : {Tax}, Seat : {Seat}, " +
               $"TransactionDate : {TransactionDate},  Rent : {Rent}, OrderPerHours : {OrderPerHours}, Driver : {DriverCost}, Total : {Total}";
        }

        public double Rent { get => rent; set => rent = value; }
        public double OrderPerHours { get => orderPerHours; set => orderPerHours = value; }
        public double DriverCost { get => driverCost; set => driverCost = value; }
    }
}
