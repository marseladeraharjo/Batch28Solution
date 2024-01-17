using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.CompilerServices;

namespace Day02
{
    internal class QuizTime
    {   
        // No 1
        public static void RemoveDuplicate(string txt)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in txt)
            {
                if(result.ToString().IndexOf(c) == -1)
                {
                    result.Append(c);
                }
            }
            Console.WriteLine(result.ToString());
        }

        // No 2
        public static void Capitalize(string txt)
        {
            string[] words = txt.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
            }
            string result = string.Join(" ", words);

            Console.WriteLine(result);
        }
        
        // No 3
        public static void CapitalizeExcept(string[] inputs, string exception)
        {

            string[] result = new string[inputs.Length];

            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] != exception)
                {
                    result[i] = char.ToUpper(inputs[i][0]) + inputs[i].Substring(1);
                }
                else
                {
                    result[i] = inputs[i];
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }

        // No 4
        public static void isBraces(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (IsOpeningBrace(c))
                {
                    stack.Push(c);
                }
                else if (IsClosingBrace(c))
                {
                    if (stack.Count == 0 || !MatchingBraces(stack.Pop(), c))
                    {
                        Console.WriteLine("false");
                    }
                }
            }

            Console.WriteLine(stack.Count == 0);
        }

        static bool IsOpeningBrace(char c)
        {
            return c == '(' || c == '{' || c == '[';
        }

        static bool IsClosingBrace(char c)
        {
            return c == ')' || c == '}' || c == ']';
        }

        static bool MatchingBraces(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']');
        }

        // No 5
        public static void FindMinMax(int[] numbers)
        {
            Stack<int> results = new Stack<int>();
            
            results.Push(numbers.Max());
            results.Push(numbers.Min());

            foreach (var result in results)
            {
                Console.Write($"{result} ");
            }
        }

        // No 6
        public static void FindMinRange(int[] arrays, int firstIndex, int lastIndex)
        {
            if (firstIndex < 0 || lastIndex > arrays.Length || firstIndex > lastIndex)
            {
                throw new ArgumentException("Invalid input");
            }

            int min = arrays[lastIndex - 1];
            int minIndex = 0;

            for (int i = firstIndex; i < lastIndex; i++)
            {
                if (arrays[i] < min)
                {
                    min = arrays[i];
                    minIndex = i;
                }
            }

            Console.WriteLine(min + ", " + minIndex);
        }

        public static void FindMaxRange(int[] arrays, int firstIndex, int lastIndex)
        {
            if (firstIndex < 0 || lastIndex > arrays.Length || firstIndex > lastIndex)
            {
                throw new ArgumentException("Invalid input");
            }

            int max = arrays[firstIndex];
            int maxIndex = 0;
            for(int i = firstIndex; i < lastIndex;i++)
            {
                if (arrays[i] > max)
                {
                    max = arrays[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine(max + ", " + maxIndex);
        }

        // No 7
        public static void EvenOddOrder(int[] arrays)
        {
            var evenNum = arrays.Where(x => x % 2 == 0);
            var oddNum = arrays.Where(x => x % 2 != 0);

            int[] resultArr = evenNum.Concat(oddNum).ToArray();

            Console.WriteLine("[" + string.Join(", ", resultArr) + "]");
        }

        // No 8
        public static void PlusOne(int[] arrays)
        {
            int lastIndex = arrays.Length - 1;

            arrays[lastIndex]++;

            if (arrays[lastIndex] == 10)
            {
                arrays[lastIndex] = 0;
                for (int i = lastIndex - 1; i >= 0; i--)
                {
                    arrays[i]++;
                    if (arrays[i] != 10)
                        break;
                    else
                        arrays[i] = 0;
                }
            }
            Console.WriteLine("[" + string.Join(", ", arrays) + "]");
        }

        // No 9
        public static void RotateArray(int[] arrays, int rotateNum)
        {
            int n = arrays.Length;

            rotateNum = rotateNum % n;

            int[] temp = new int[rotateNum];

            arrays.AsSpan().Slice(0, rotateNum).CopyTo(temp);

            arrays.AsSpan().Slice(rotateNum, n - rotateNum).CopyTo(arrays.AsSpan());


            temp.AsSpan().CopyTo(arrays.AsSpan().Slice(n - rotateNum, rotateNum));

            Console.WriteLine("[" + string.Join(", ", arrays) + "]");
        }

        // Quiz Time Matrix
        // No 1
        public static int[,] MatrixNo1(int n)
        {
            int[,] matrix = new int[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[0, i] = i;
                matrix[i, n - 1] = n + i - 1;
                matrix[n - 1, i] = n + i - 1;
                matrix[i, 0] = i;
            }

            return matrix;
        }

        public static void ShowMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // No 2
        public static int[,] MatrixNo2(int n)
        {
            int[,] matrix = new int[n+1, n+1];


            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    matrix[i, j] = j + i;
                }
            }

            for (int j = 0; j < n; j++)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += matrix[i, j];
                }
                matrix[n, j] = sum;
            }

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += matrix[i, j];
                }
                matrix[i, n] = sum;
            }

            int diagonalSum = 0;
            for (int i = n - 1; i > 0; i--)

            {
                diagonalSum += matrix[i, i];
            }
            matrix[n, n] = diagonalSum;

            return matrix;
        }

        // No 3
        public static int[,] MatrixNo3(int n)
        {
            int[,] matrix = new int[n, n];
            int startNum = 2;
            int step = 3;
            int counter = 0;

            for (int i = n; i > 0; i--)
            {
                matrix[i - 1, n - i] = startNum + (counter * step);
                if (i == 3)
                {
                    matrix[i, i] = 3;
                    continue;
                }
                counter++;
            }

            for (int i = 0; i < n; i++)
            {
                matrix[i, n - 1] = startNum + (n - 1) + ((counter - 3) * step);
                if (i == 1)
                {
                    matrix[i, n - 1] = 9;
                    continue;
                }
                if (i == 5)
                {
                    matrix[i, n - 1] = 27;
                    continue;
                }
                counter++;
            }

            for (int i = n - 1; i > 0; i--)
            {
                matrix[n - 1, i] = startNum + (2 * n - 2) + ((counter - 6) * step);
                if (i == 3)
                {
                    matrix[n - 1, i] = 81;
                    continue;
                }
                counter++;
            }

            return matrix;
        }

        // No 4
        public static int[,] MatrixNo4(int n)
        {
            int[,] matrix = new int[n, n];
            int startNum = 2;
            int step = 3;
            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[0, i] = startNum + counter * step;
                if (i == 3)
                {
                    matrix[0, i] = 3;
                    continue;
                }
                counter++;
            }

            for (int i = 0; i < n; i++)
            {
                matrix[i, n - 1] = startNum + (n - 1) + ((counter - 3) * step);
                if (i == 1 || i == 5)
                {
                    matrix[i, n - 1] = 3;
                    continue;
                }
                counter++;
            }

            for (int i = n - 1; i > 0; i--)
            {
                matrix[n - 1, i] = startNum + (2 * n - 2) + ((counter - 6) * step);
                if (i == 3)
                {
                    matrix[n - 1, i] = 3;
                    continue;
                }
                counter++;
            }

            for (int i = n - 1; i > 0; i--)
            {
                matrix[i, 0] = startNum + (3 * n - 3) + ((counter - 8) * step);
                if (i == 1 || i == 5)
                {
                    matrix[i, 0] = 3;
                    continue;
                }
                counter++;
            }
            return matrix;
        }

        // No 5
        public static void MatrixNo5()
        {
            int[] answerKey = new int[10] { 'D', 'B', 'D', 'C', 'C', 'D', 'A', 'E', 'A', 'D' };

            int[,] matrix = new int[8, 10]
            {
                { 'A', 'B', 'A', 'C', 'C', 'D', 'E', 'E', 'A', 'D' },
                { 'D', 'B', 'A', 'B', 'C', 'A', 'E', 'E', 'A', 'D' },
                { 'E', 'D', 'D', 'A', 'C', 'B', 'E', 'E', 'A', 'D' },
                { 'C', 'B', 'A', 'E', 'D', 'C', 'E', 'E', 'A', 'D' },
                { 'A', 'B', 'D', 'C', 'C', 'D', 'E', 'E', 'A', 'D' },
                { 'B', 'B', 'E', 'C', 'C', 'D', 'E', 'E', 'A', 'D' },
                { 'B', 'B', 'A', 'C', 'C', 'D', 'E', 'E', 'A', 'D' },
                { 'E', 'B', 'E', 'C', 'C', 'D', 'E', 'E', 'A', 'D' },
            };

            int[] rightAnswer = new int[8];
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++, counter++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (answerKey[j] == matrix[i, j]) rightAnswer[counter]++;
                }
            }

            for (int i = 0; i < rightAnswer.Length; i++)
            {
                Console.WriteLine($"Jawaban Siswa {i} yang benar : {rightAnswer[i]}");
            }
        }
    }
}
