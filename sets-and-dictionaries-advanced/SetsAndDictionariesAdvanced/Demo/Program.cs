using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            numbers[0] = 15;
            numbers[1] = 100;
            numbers[2] = 500;

            // numbers["Ivan"] = 5;

            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict["Ivan"] = 5;
            dict["Maria"] = 50;

            dict.Add("Pesho", 10);

            dict.Remove("Maria");

            if (dict.ContainsKey("Ivan"))
            {
                Console.WriteLine(dict["Ivan"]);
            }

            Console.WriteLine();

            HashSet<string> names = new HashSet<string>();

            names.Add("Ivan");
            names.Add("Pesho");
            names.Add("Pesho");
            names.Add("Pesho");
            names.Add("Pesho");
            names.Add("Pesho");
            names.Add("Pesho");
            names.Add("Ivan");
            names.Add("Mariika");
            names.Add("Goshko");
            names.Add("Stanimir");

            names.Remove("Stanimir");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
