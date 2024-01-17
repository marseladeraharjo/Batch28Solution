using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day01
{
    internal class QuizTime
    {
        // No 1
        public static void TriangleStars(int row)
        {
            for (int i = row; i >= 1; i--)
            {
                // print space
                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }

                // print star
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("");

            for (int i = 1; i <= row; i++)
            {
                // print space
                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }

                // print star
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        // No 2
        public static void Pyramid()
        {
            Console.Write("Masukkan jumlah baris piramid: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input jumlah baris piramid: {n}");

            for (int i = n; i >= 1; i--)
            {
                
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }

                for (int k = 2; k <= i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }

        // No 3
        public static void ShowPrimeNumber(int n)
        {
            int number = 2;

            while (number < n)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                }

                number++;
            }
            Console.WriteLine();
        }

        static bool IsPrime(int num)
        {
            if (num < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        // No 4
        public static void FindDivisor(int n)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }

        // No 5
        public static void ShowNumbers(int n)
        {
            int firstNum = 1;
            int secNum = n;

            for(int i = 1;i <= n;i++)
            {
                for(int j = 1;j <= n;j++)
                {
                    if(j % 2 == 1)
                    {
                        Console.Write(firstNum);
                    } else
                    {
                        Console.Write(secNum);
                    }
                    
                }

                firstNum++;
                secNum--;
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // No 6
        public static void ShowNumbersTwo(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if(i % 2 == 1)
                    {
                        if (j % 2 == 1)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write(j);
                        }
                    } else
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write(j);
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();    
        }

        // No 7
        public static void PerfectNumber(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (IsPerfectNumber(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static bool IsPerfectNumber(int n)
        {
            int sum = 1;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (i * i != n)
                    {
                        sum += n / i;
                    }
                }
            }

            return sum == n;
        }

        // No 8
        public static void IsPalindromNumber(int num)
        {
            int originalNumber = num;
            int reversedNumber = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversedNumber = reversedNumber * 10 + digit;
                num /= 10;
            }

            Console.WriteLine(originalNumber == reversedNumber);
        }
    }
}
