using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay04
{
    internal interface IVehicle
    {
        List<Vehicle> InitVehicleList();

        public void DisplayVehicle(List<Vehicle> vehicles);

        double GetTotalVehicle(List<Vehicle> vehicles);
        double GetTotalVehicle(List<Vehicle> vehicles, string type);

        double GetTotalIncomeVehicle(List<Vehicle> vehicles);

        double GetTotalIncomeVehicle(List<Vehicle> vehicles, string type);
    }
}
