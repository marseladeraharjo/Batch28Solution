using Day05;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new() { EmpId = 1, FullName = "Code" };


        Console.WriteLine(employee.ToString());

        Employee employee2 = new() { FullName = "Bootcamp" };
        Console.WriteLine(employee2.ToString());
    }
}