using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class Array
    {

        // 7
        public static int[] CopyArray(int[] source)
        {
            int[] target = new int[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
            return target;
        }


        // 6
        public static int FindMaxIndex(int[] arrays)
        {
            int max = arrays[0];
            int indexOfMax = 0;
            for (int i = 1; i < arrays.Length; i++)
            {
                if (arrays[i] > max)
                {
                    max = arrays[i];
                    indexOfMax = i;
                }

            }
            return indexOfMax;
        }

        // 5
        public static int FindMaxElement(int[] arrays)
        {
            int max = arrays[0];
            for(int i = 1; i < arrays.Length; i++)
            {
                if (arrays[i] > max)
                {
                    max = arrays[i];
                }

            }
            return max;
        }

        // 4
        public static int SumTotalArray(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum += item;
            }
            return sum;
        }

        // 3
        public static void DisplayArrayInt(int[] arrays)
        {
            foreach (var array in  arrays)
            {
                Console.Write($"{array.ToString()} ");
            }
        }

        // 2 
        public static int[] InitArrayInteger(int n)
        {
            int[] arr = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(51);
            }

            return arr;
        }

        // 1 Init array
        public static void IntroArray()
        {
            // declare array
            int[] arr;
            int[] arr1 = new int[3];
            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;

            // declare double
            double[] arrDouble = new double[3];
            arrDouble[1] = 34.5;

            // inisialisasi array
            double[] price = new double[] { 100, 200, 300 };
            string[] girls = new string[] { "rini", "yuli", "widi" };
            char[] chars = new char[] { 'a', 'b', 'c' };

            // display array 
            foreach (var item in girls)
            {
                Console.WriteLine($"{item} ");
            }


        }
    }
}
