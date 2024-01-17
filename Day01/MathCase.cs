using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class MathCase
    {

        // Fibonnaci case
        public static void FiboVar(int maxNumber)
        {
            int first = 0;
            int second = 1;
            int fibo = 1;

            for (int i = 0; i < maxNumber; i++)
            {
                Console.Write($"{fibo} ");
                fibo = first + second;
                first = second;
                second = fibo; 
            }
        }


        // Prime Number Case with return method
        public static bool isPrimeNumber(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        // ATM Case
        public static void ATM()
        {
            int digit1, digit2, digit3, sisa;

            Console.WriteLine("Enter money: ");
            int money = Convert.ToInt32(Console.ReadLine());

            digit1 = money / 50_000;
            sisa = money % 50_000;

            digit2 = sisa / 10_000;
            sisa = sisa % 10_000;

            digit3 = sisa / 5_000;
            sisa = sisa % 5_000;

            Console.WriteLine($"$50 = {digit1} \n $10 = {digit2} \n $5 = {digit3} \n sisa = {sisa}");
        }


        // FizzBuzz Case
        public static void FizzBuzz(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i%3 == 0 && i%5 ==0)
                {
                    Console.WriteLine($"{i} FizzBuzz");
                }
                else if (i%3 == 0)
                {
                    Console.WriteLine($"{i} Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }


        // 2
        public static void SetLocalVariable()
        { 
            // Primitive data type
            int population = 10_000;
            double weight = 1.99;
            double price = 4.999;
            long myID = 1;
            string fruit = "orange";
            char letter = 'A';
            bool isGraduated = true;
        }
        

        // 1
        public static void ShowMultiplePrint()
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Dotnet");

            // 02
            Console.WriteLine("code academy" + "Bootcamp .net");

            Console.WriteLine("Code Academy \n Cool Dotnet");

            // 03 Verbatim
            Console.WriteLine(@"Bootcamp .NET with
            Code Academy
            ");

            // 04
            Console.WriteLine("Temperature di sentul tanggal {0}, suhu: {1} celcius", DateTime.Today, 20.0);

            Console.WriteLine($"Today is : {0}", DateTime.Today);
        }
    }
}
