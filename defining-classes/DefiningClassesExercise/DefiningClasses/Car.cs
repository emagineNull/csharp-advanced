using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = 0;
            this.Color = "n/a";
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }


        public string Model { get; private set; }
        
        public Engine Engine { get; private set; }

        public int Weight { get; private set; }

        public string Color { get; private set; }

        //private string model;
        //private Engine engine;
        //private Cargo cargo;
        //private Tire[] tires;

        //public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        //{
        //    this.Model = model;
        //    this.Engine = engine;
        //    this.Cargo = cargo;
        //    this.Tires = tires;
        //}

        //public void Printer(List<Car> cars, string command)
        //{
        //    if (command == "fragile")
        //    {
        //        cars
        //            .Where(c => c.Cargo.Type == "fragile")
        //            .Where(c => c.Tires.Any(t => t.Pressure < 1))
        //            .ToList()
        //            .ForEach(x => Console.WriteLine(x.Model));
        //    }
        //    else if (command == "flamable")
        //    {
        //        cars
        //            .Where(c => c.Cargo.Type == "flamable")
        //            .Where(c => c.Engine.Power > 250)
        //            .ToList()
        //            .ForEach(x => Console.WriteLine(x.Model));
        //    }
        //}

        //public string Model { get; private set; }

        //public Engine Engine { get; private set; }

        //public Cargo Cargo { get; private set; }

        //public Tire[] Tires { get; private set; }


        //private string model;
        //private double fuelAmount;
        //private double fuelConsumptionPerKm;
        //private double travelledDistance;

        //public Car(string model, double fuelAmount, double fuelConsumptionPerKm, double travelledDistance)
        //{
        //    this.Model = model;
        //    this.FuelAmount = fuelAmount;
        //    this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        //    this.TravelledDistance = travelledDistance;
        //}

        //public string Model
        //{
        //    get { return this.model; }
        //    set { this.model = value; }
        //}

        //public double FuelAmount
        //{
        //    get { return this.fuelAmount; }
        //    set { this.fuelAmount = value; }
        //}

        //public double FuelConsumptionPerKm
        //{
        //    get { return this.fuelConsumptionPerKm; }
        //    set { this.fuelConsumptionPerKm = value; }
        //}

        //public double TravelledDistance
        //{
        //    get { return this.travelledDistance; }
        //    set { this.travelledDistance = value; }
        //}

        //public void Drive(double amountOfKm)
        //{

        //    bool canContinue = this.FuelAmount - (this.FuelConsumptionPerKm * amountOfKm) >= 0;

        //    if (canContinue)
        //    {
        //        this.FuelAmount -= (this.FuelConsumptionPerKm * amountOfKm);
        //        this.TravelledDistance += amountOfKm;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Insufficient fuel for the drive");
        //    }
        //}
    }
}
