using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay04
{
    internal class VehicleImpl : IVehicle
    {
        public void DisplayVehicle(List<Vehicle> vehicles)
        {
            foreach (Vehicle vhc in vehicles)
            {
                Console.WriteLine(vhc.ToString());
                Console.WriteLine();
            }
        }

        public double GetTotalIncomeVehicle(List<Vehicle> vehicles)
        {
            var total = 0.0;

            foreach (Vehicle vhc in vehicles)
            {
                total += vhc.Total;
            }
            return total;
        }

        public double GetTotalIncomeVehicle(List<Vehicle> vehicles, string type)
        {
            var vhcByType = vehicles.FindAll(v => v.VehicleType == type);
            var total = 0.0;

            foreach (Vehicle vhc in vhcByType)
            {
                total += vhc.Total;
            }

            return total;
        }

        public double GetTotalVehicle(List<Vehicle> vehicles)
        {
            return Vehicle.totalVehicle;
        }

        public double GetTotalVehicle(List<Vehicle> vehicles, string type)
        {
            var vhcByType = vehicles.FindAll(v => v.VehicleType == type);
            return vhcByType.Count;

        }

        public List<Vehicle> InitVehicleList()
        {
            var listVehicle = new List<Vehicle>();

            // SUV Object
            SUV suv1 = new SUV("D 1001 UM", "SUV", 2010, 350_000_000, 3_500_000, 4, DateTime.Now, 500_000, 150_000, 0);
            SUV suv2 = new SUV("D 1002 UM", "SUV", 2010, 350_000_000, 3_500_000, 4, DateTime.Now, 500_000, 150_000, 0);
            SUV suv3 = new SUV("D 1003 UM", "SUV", 2015, 350_000_000, 3_500_000, 5, DateTime.Now, 500_000, 150_000, 0);
            SUV suv4 = new SUV("D 1004 UM", "SUV", 2015, 350_000_000, 3_500_000, 5, DateTime.Now, 500_000, 150_000, 0);


            // Taxi Object
            Taxi taxi1 = new Taxi("D 11 UK", "Taxi", 2002, 175_000_000, 1_750_000, 4, DateTime.Now, 45, 4_500, 0);
            Taxi taxi2 = new Taxi("D 12 UK", "Taxi", 2015, 225_000_000, 2_250_000, 4, DateTime.Now, 75, 4_500, 0);
            Taxi taxi3 = new Taxi("D 13 UK", "Taxi", 2020, 275_000_000, 2_750_000, 4, DateTime.Now, 90, 4_500, 0);

            // PrivateJet Object
            PrivateJet pvj1 = new PrivateJet("ID8089", "PrivateJet", 2015, 150_000_000_000, 1_500_000_000, 12, DateTime.Now, 35_000_000, 25_000_000, 15_000_000, 0);
            PrivateJet pvj2 = new PrivateJet("ID8099", "PrivateJet", 2018, 175_000_000_000, 1_750_000_000, 15, DateTime.Now, 55_000_000, 25_000_000, 25_000_000, 0);
            
            listVehicle.Add(suv1);
            listVehicle.Add(suv2);
            listVehicle.Add(suv3);
            listVehicle.Add(suv4);

            listVehicle.Add(taxi1);
            listVehicle.Add(taxi2);
            listVehicle.Add(taxi3);

            listVehicle.Add(pvj1);
            listVehicle.Add(pvj2);

            return listVehicle;
        }

    }
}
