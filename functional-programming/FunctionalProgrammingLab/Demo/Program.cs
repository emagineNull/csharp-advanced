using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Demo
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        public delegate int Calculation(int x, int y);

        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var list = new List<int> { 1, 2, 3, 4 };

            var result1 = list.Where(x => x % 2 == 0).ToList();
            var result2 = list.Where(Filter).ToList();

            Calculation sum = (a, b) => a + b;
            Calculation product = (x, y) => x * y;

            var result = sum(1, 2);
            var anotherResult = product(1, 2);

            UseDelegate(sum);
            UseDelegate(product);


            Func<int> someFunc = () => 1;
            someFunc = () => SomeFunction();

            DoWork(() => 42);
            DoWork(() => 3 + 4);
            DoWork(() => int.Parse("1"));

            Console.WriteLine();

            Func<int, int, int> s = Sum;

            Console.WriteLine(s(5, 6));

            Console.WriteLine();

            Func<double, bool, char, string> calc = Calculate;

            Func<string, int, Cat> catFunc = GetCat;

            Action<int, int, int> action = NewCalculate;
            action += (x, y, z) => Console.WriteLine(x + y + z);
            action += (x, y, z) => Console.WriteLine(x - y - z);
            action -= NewCalculate;

            action(1, 2, 4);

            LogMessage("Error: Something went wrong!", msg => Console.WriteLine(msg));
            LogMessage("Everything works!", msg => File.WriteAllText("log.txt", msg));
        }

        public static void LogMessage(string message, Action<string> logAction)
        {
            if (message.StartsWith("Error"))
            {
                message = message.ToUpper();
            }
            else
            {
                Console.WriteLine($"Warning: {message}");
            }

            logAction(message);
        }

        public static void NewCalculate(int a, int b, int c)
        {
            Console.WriteLine(a * b * c);
        }

        public static Cat GetCat(string name, int age)
        {
            return new Cat();
        }

        public static string Calculate(double a, bool b, char c)
        {
            return "";
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static void DoWork(Func<int> callback)
        {
            var result = callback();

            Console.WriteLine(result);
        }

        public static int SomeFunction()
        {
            return 42;
        }

        public static void UseDelegate(Calculation calculation)
        {
            Console.WriteLine(calculation(1, 2));
        }

        public static bool Filter(int x)
        {
            return x % 2 == 0;
        }
    }
}
