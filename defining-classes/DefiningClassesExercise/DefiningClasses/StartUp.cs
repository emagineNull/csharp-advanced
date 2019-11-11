using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //var pesho = new Person("Pesho", 28);
            //var gosho = new Person("Gosho", 18);
            //var stamat = new Person("Stamat", 43);

            //var testPerson = new Person();

            //Console.WriteLine(testPerson.Name + " " + testPerson.Age);

            //var testPerson2 = new Person(25);

            //Console.WriteLine(testPerson2.Name + " " + testPerson2.Age);

            //int n = int.Parse(Console.ReadLine());
            //var family = new Family();

            //for (int i = 0; i < n; i++)
            //{
            //    string[] input = Console.ReadLine().Split();

            //    var person = new Person(input[0], int.Parse(input[1]));

            //    family.AddMember(person);
            //}

            //var oldestMember = family.GetOldestMember();

            //Console.WriteLine(oldestMember.Name + " " + oldestMember.Age);

            //int n = int.Parse(Console.ReadLine());
            //var people = new List<Person>();

            //for (int i = 0; i < n; i++)
            //{
            //    string[] input = Console.ReadLine().Split();

            //    var person = new Person(input[0], int.Parse(input[1]));
            //    people.Add(person);
            //}

            //var peopleOver30 = people.OrderBy(p => p.Name).Where(p => p.Age > 30);

            //foreach (var person in peopleOver30)
            //{
            //    Console.WriteLine($"{person.Name} - {person.Age}");
            //}

            //var firstDate = Console.ReadLine();
            //var secondDate = Console.ReadLine();
            //Console.WriteLine(DateModifier.GetDaysBetweenDates(firstDate, secondDate));

            //var employees = GetEmployees();
            //PrintEmployeesWithHighestSalary(employees);


        }

        //private static void PrintEmployeesWithHighestSalary(Stack<Employee> employees)
        //{
        //    if (employees.Count == 0)
        //    {
        //        return;
        //    }

        //    var highestAverageSalaryDepartment = employees
        //        .GroupBy(e => e.Department)
        //        .OrderByDescending(g => g.Select(e => e.Salary).Sum())
        //        .First();

        //    Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment.Key}");
        //    Console.WriteLine(string.Join(Environment.NewLine, highestAverageSalaryDepartment
        //        .OrderByDescending(e => e.Salary)
        //        .Select(e => $"{e.Name} {e.Salary:F2} {e.Email} {e.Age}")));
        //}

        //private static Stack<Employee> GetEmployees()
        //{
        //    var employees = new Stack<Employee>();
        //    var numberOfEmployees = int.Parse(Console.ReadLine());

        //    while (employees.Count < numberOfEmployees)
        //    {
        //        var email = "n/a";
        //        var age = -1;
        //        var personData = Console.ReadLine().Split();

        //        if (personData.Length > 4)
        //        {
        //            int parsed;
        //            var isdigit = int.TryParse(personData[4], out parsed);

        //            if (isdigit)
        //            {
        //                age = parsed;
        //            }
        //            else
        //            {
        //                email = personData[4];
        //            }

        //            if (personData.Length > 5)
        //            {
        //                if (isdigit)
        //                {
        //                    email = personData[5];
        //                }
        //                else
        //                {
        //                    age = int.Parse(personData[5]);
        //                }
        //            }
        //        }

        //        employees.Push(new Employee(
        //                personData[0],
        //                double.Parse(personData[1]),
        //                personData[2],
        //                personData[3],
        //                email,
        //                age
        //            ));
        //    }

        //    return employees;
        //}
    }
}
