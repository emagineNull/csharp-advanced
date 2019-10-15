using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] currentInput = Console.ReadLine().Split();

                string name = currentInput[0];
                double grade = double.Parse(currentInput[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }

                grades[name].Add(grade);
            }

            foreach (var kvp in grades)
            {
                var name = kvp.Key;
                var currentGrades = kvp.Value;

                Console.Write($"{name} -> ");

                foreach (var currentGrade in currentGrades)
                {
                    Console.Write($"{currentGrade:f2} ");
                }

                var averageGrade = currentGrades.Average();

                Console.WriteLine($"(avg: {averageGrade:f2})");
            }
        }
    }
}
