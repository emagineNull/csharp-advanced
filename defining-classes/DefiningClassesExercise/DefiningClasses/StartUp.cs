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


            //int n = int.Parse(Console.ReadLine());
            //var cars = new List<Car>();

            //for (int i = 0; i < n; i++)
            //{
            //    string[] inputParts = Console.ReadLine().Split();

            //    string model = inputParts[0];
            //    double fuelAmount = double.Parse(inputParts[1]);
            //    double fuelConsumptionPerKm = double.Parse(inputParts[2]);

            //    var car = new Car(model, fuelAmount, fuelConsumptionPerKm, 0);
            //    cars.Add(car);
            //}

            //string command = Console.ReadLine();

            //while (command != "End")
            //{
            //    string[] tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            //    string model = tokens[1];
            //    double distance = double.Parse(tokens[2]);

            //    cars.Where(c => c.Model == model).ToList().ForEach(c => c.Drive(distance));

            //    command = Console.ReadLine();
            //}

            //foreach (var car in cars)
            //{
            //    Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            //}

            //int n = int.Parse(Console.ReadLine());
            //var cars = new List<Car>();

            //for (int i = 0; i < n; i++)
            //{
            //    string[] input = Console.ReadLine().Split();

            //    string model = input[0];
            //    int engineSpeed = int.Parse(input[1]);
            //    int enginePower = int.Parse(input[2]);
            //    int cargoWeight = int.Parse(input[3]);
            //    string cargoType = input[4];
            //    double tire1Pressure = double.Parse(input[5]);
            //    int tire1Age = int.Parse(input[6]);
            //    double tire2Pressure = double.Parse(input[7]);
            //    int tire2Age = int.Parse(input[8]);
            //    double tire3Pressure = double.Parse(input[9]);
            //    int tire3Age = int.Parse(input[10]);
            //    double tire4Pressure = double.Parse(input[11]);
            //    int tire4Age = int.Parse(input[12]);

            //    var engine = new Engine(engineSpeed, enginePower);
            //    var cargo = new Cargo(cargoWeight, cargoType);
            //    var tires = new Tire[4]
            //    {
            //        new Tire(tire1Age, tire1Pressure),
            //        new Tire(tire2Age, tire2Pressure),
            //        new Tire(tire3Age, tire3Pressure),
            //        new Tire(tire4Age, tire4Pressure)
            //    };
            //    var car = new Car(model, engine, cargo, tires);
            //    cars.Add(car);
            //}

            //string command = Console.ReadLine();

            //if (command == "fragile")
            //{
            //    cars
            //        .Where(c => c.Cargo.Type == "fragile")
            //        .Where(c => c.Tires.Any(t => t.Pressure < 1))
            //        .ToList()
            //        .ForEach(x => Console.WriteLine(x.Model));
            //}
            //else if (command == "flamable")
            //{
            //    cars
            //        .Where(c => c.Cargo.Type == "flamable")
            //        .Where(c => c.Engine.Power > 250)
            //        .ToList()
            //        .ForEach(x => Console.WriteLine(x.Model));
            //}


            //int n = int.Parse(Console.ReadLine());
            //var engines = new List<Engine>();

            //for (int i = 0; i < n; i++)
            //{
            //    string[] tokens = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            //    string model = tokens[0];
            //    string power = tokens[1];

            //    if (tokens.Length == 2)
            //    {
            //        engines.Add(new Engine(model, power));
            //    }
            //    else if (tokens.Length == 3)
            //    {
            //        int displacement;
            //        bool isDisplacement = int.TryParse(tokens[2], out displacement);
            //        if (isDisplacement)
            //        {
            //            engines.Add(new Engine(model, power, displacement));
            //        }
            //        else
            //        {
            //            string efficiency = tokens[2];
            //            engines.Add(new Engine(model, power, efficiency));
            //        }
            //    }
            //    else if (tokens.Length == 4)
            //    {
            //        int displacement = int.Parse(tokens[2]);
            //        string efficiency = tokens[3];
            //        engines.Add(new Engine(model, power, displacement, efficiency));
            //    }
            //}

            //int carsCount = int.Parse(Console.ReadLine());
            //List<Car> cars = new List<Car>();

            //for (int i = 0; i < carsCount; i++)
            //{
            //    string[] tokens = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            //    string model = tokens[0];
            //    string engineModel = tokens[1];
            //    Engine engine = new Engine(null, null);

            //    foreach (Engine eng in engines)
            //    {
            //        if (eng.Model == engineModel)
            //        {
            //            engine = eng;
            //        }
            //    }

            //    if (tokens.Length == 2)
            //    {
            //        cars.Add(new Car(model, engine));
            //    }
            //    else if (tokens.Length == 3)
            //    {
            //        int weight;
            //        bool isWeight = int.TryParse(tokens[2], out weight);
            //        if (isWeight)
            //        {
            //            cars.Add(new Car(model, engine, weight));
            //        }
            //        else
            //        {
            //            string color = tokens[2];
            //            cars.Add(new Car(model, engine, color));
            //        }
            //    }
            //    else if (tokens.Length == 4)
            //    {
            //        int weight = int.Parse(tokens[2]);
            //        string color = tokens[3];
            //        cars.Add(new Car(model, engine, weight, color));
            //    }
            //}

            //foreach (Car car in cars)
            //{
            //    Console.WriteLine("{0}:", car.Model);
            //    Console.WriteLine("  {0}:", car.Engine.Model);
            //    Console.WriteLine("    Power: {0}", car.Engine.Power);
            //    Console.WriteLine("    Displacement: {0}", car.Engine.Displacement == 0 ? "n/a" : car.Engine.Displacement.ToString());
            //    Console.WriteLine("    Efficiency: {0}", car.Engine.Efficiency);
            //    Console.WriteLine("  Weight: {0}", car.Weight == 0 ? "n/a" : car.Weight.ToString());
            //    Console.WriteLine("  Color: {0}", car.Color);
            //}

            var trainers = new List<Trainer>();
            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                string[] commandParts = command.Split();

                string trainerName = commandParts[0];
                string pokemonName = commandParts[1];
                string pokemonElement = commandParts[2];
                int pokemonHealth = int.Parse(commandParts[3]);

                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.Any(tn => tn.Name == trainerName))
                {
                    var trainer = new Trainer(trainerName, 0, new List<Pokemon>());
                    trainers.Add(trainer);
                }

                trainers.Find(tn => tn.Name == trainerName).Pokemons.Add(pokemon);

                command = Console.ReadLine();
            }

            string command2 = Console.ReadLine();

            while (command2 != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == command2))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            trainer.Pokemons[i].Health -= 10;
                            if (trainer.Pokemons[i].Health <= 0)
                            {
                                trainer.Pokemons.RemoveAt(i);
                            }
                        }
                    }
                }

                command2 = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(b => b.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
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
