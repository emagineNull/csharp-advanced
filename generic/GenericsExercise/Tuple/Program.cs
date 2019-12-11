using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();

            string name = input1[0] + " " + input1[1];
            string address = input1[2];

            var first = new Tuple<string, string>(name, address);

            string[] input2 = Console.ReadLine().Split();

            string nameBeer = input2[0];
            int litresBeer = int.Parse(input2[1]);

            var second = new Tuple<string, int>(nameBeer, litresBeer);

            string[] input3 = Console.ReadLine().Split();

            int integer = int.Parse(input3[0]);
            double floatingPoint = double.Parse(input3[1]);

            var third = new Tuple<int, double>(integer, floatingPoint);

            Console.WriteLine($"{first.Item1} -> {first.Item2}");
            Console.WriteLine($"{second.Item1} -> {second.Item2}");
            Console.WriteLine($"{third.Item1} -> {third.Item2}");
        }
    }
}
