namespace QuizDay04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IVehicle vehicleInf = new VehicleImpl();

            var listVehicles = vehicleInf.InitVehicleList();

            vehicleInf.DisplayVehicle(listVehicles);

            var totalVehicle = vehicleInf.GetTotalVehicle(listVehicles);
            Console.WriteLine($"Total Vehicle : {totalVehicle}");

            var totalSUV = vehicleInf.GetTotalVehicle(listVehicles, "SUV");
            Console.WriteLine($"Total SUV : {totalSUV}");

            var totalTaxi = vehicleInf.GetTotalVehicle(listVehicles, "Taxi");
            Console.WriteLine($"Total Taxi : {totalTaxi}");

            var totalPvJet = vehicleInf.GetTotalVehicle(listVehicles, "PrivateJet");
            Console.WriteLine($"Total PrivateJet : {totalPvJet}");

            var totalIncomeSUV = vehicleInf.GetTotalIncomeVehicle(listVehicles, "SUV");
            Console.WriteLine($"Total Income SUV : {totalIncomeSUV}");

            var totalIncomeTaxi = vehicleInf.GetTotalIncomeVehicle(listVehicles, "Taxi");
            Console.WriteLine($"Total Income Taxi : {totalIncomeTaxi}");

            var totalIncomePJ = vehicleInf.GetTotalIncomeVehicle(listVehicles, "PrivateJet");
            Console.WriteLine($"Total Income PrivateJet : {totalIncomePJ}");

            var totalIncome = vehicleInf.GetTotalIncomeVehicle(listVehicles);
            Console.WriteLine($"Total Income : {totalIncome}");
        }
    }
}
