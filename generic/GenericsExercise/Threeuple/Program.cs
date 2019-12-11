using System;

namespace Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();

            string name = input1[0] + " " + input1[1];
            string address = input1[2];
            string town = input1[3];

            var first = new Threeuple<string, string, string>(name, address, town);
            Console.WriteLine(first);

            string[] input2 = Console.ReadLine().Split();

            string nameBeer = input2[0];
            int litresBeer = int.Parse(input2[1]);
            bool drunkOrNot = input2[2] == "drunk" ? true : false;

            var second = new Threeuple<string, int, bool>(nameBeer, litresBeer, drunkOrNot);
            Console.WriteLine(second);

            string[] input3 = Console.ReadLine().Split();

            string nameBank = input3[0];
            double bankBalance = double.Parse(input3[1]);
            string bankName = input3[2];

            var third = new Threeuple<string, double, string>(nameBank, bankBalance, bankName);
            Console.WriteLine(third);
        }
    }
}
