using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay04
{
    internal abstract class Vehicle
    {
        private string vehicleType;
        private int year;
        private double price;
        private double tax;
        private int seat;
        private DateTime transactionDate;
        private double total;

        public static int totalVehicle = 0;

        public string VehicleType { get => vehicleType; set => vehicleType = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }
        public double Tax { get => tax; set => tax = value; }
        public int Seat { get => seat; set => seat = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        public double Total { get => total; set => total = value; }

        protected Vehicle(string vehicleType, int year, double price, double tax, int seat, DateTime transactionDate, double total)
        {
            this.vehicleType = vehicleType;
            this.year = year;
            this.price = price;
            this.tax = tax;
            this.seat = seat;
            this.transactionDate = transactionDate;
            this.total = total;
            totalVehicle++;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
