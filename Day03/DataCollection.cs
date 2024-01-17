using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class DataCollection
    {
        // 1. List
        public static void InitList()
        {
            var alfabet = new List<string> { "A", "B", "C", "D", "E" };
            alfabet.Add("F");
            alfabet.AddRange(new[] { "G", "H", "I" });
            alfabet.Insert(0, "a");
            alfabet.InsertRange(3, new[] { "X", "Y" });

            foreach (var item in alfabet)
            {
                Console.Write(item + " ");
            }

            // find element
            var number = new List<int> { 2, 5, 7, 11, 13, 17, 23 };

            number.Add(1);
            number.Remove(1);
            number.Add(10);
            number.Add(12);

            number.RemoveAll(number => number % 2 == 0);

            // find element
            var lessThan10 = number.Find(e => e < 10);
        }

        // 2. Stack
        // last in first out
        public static void InitStack()
        {
            var numbers = new Stack<int>(new int[] {1, 2, 3});
            numbers.Push(5);
            numbers.Push(7);

            // remove pop
            numbers.Pop();
            var n = numbers.Peek();
            numbers.Clear();
        }

        // 3. Dictionary
        public static void InitDictionary()
        {
            var pl = new Dictionary<int, string>();
            pl.Add(1, "C#");
            pl.Add(2, "Java");

            var pl2 = new Dictionary<int, string>()
            {
                {1, "Oracle" },
                {2, "SQL Server" },
                {3, "MySQL" }
            };

            //pl2.Add(3, "Postgres");
            //pl2.TryAdd(3, "Postgres");

            pl2[3] = "PostgreSQL";

            foreach (var item in pl2)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }

        // 4. Hashset (store unique value/element)
        public static void InitHashset()
        {
            HashSet<int> numbers = new HashSet<int>() { 1,2, 4, 5, 6, 7};
            numbers.Add(5);
            numbers.Add(10);

            foreach(var item in numbers)
            {
                Console.Write($"{item} ");
            }

            var hs1 = new HashSet<int>() { 1, 2, 5, 6, 9};
            var hs2 = new HashSet<int>() { 1, 2, 3, 4 };
            var result = new HashSet<int>(hs1);
            result.IntersectWith(hs2); // inner join => 1, 2

            var result2 = new HashSet<int>(hs1);
            result2.UnionWith(hs2); // union => 1, 2, 3, 4, 5, 6, 9

            var result3 = new HashSet<int>(hs1);
            result3.ExceptWith(hs2); // 5, 6, 9

            var result4 = new HashSet<int>(hs1);
            result4.SymmetricExceptWith(hs2); // 3, 4, 5, 6, 9

            // convert hashset to list
            var myNumber = result4.ToList();
        }

        // 5. Queue
        public static void InitQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("asep");
            queue.Enqueue("budi");
            queue.Enqueue("charlie");

            Console.WriteLine($"Queue from front to back");
            foreach (var item in queue)
            {
                Console.WriteLine($"{item} ");
            }

            string served = queue.Dequeue();
            Console.WriteLine($"served : {served}");

            Console.WriteLine($"Current queue from front to back");
            foreach(var item in queue)
            {
                Console.WriteLine($"{item}");
            }

            served = queue.Dequeue();
            Console.WriteLine($"served : {served}");
        }
    }
}
