using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        private string model;
        private string power;
        private int displacement;
        private string efficiency;

        public Engine(string model, string power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = 0;
            this.Efficiency = "n/a";
        }

        public Engine(string model, string power, int displacement)
            : this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, string power, string efficiency)
            : this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, string power, int displacement, string efficiency)
            : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public string Model { get; private set; }

        public string Power { get; private set; }

        public int Displacement { get; private set; }

        public string Efficiency { get; private set; }

        //private int speed;
        //private int power;

        //public Engine(int speed, int power)
        //{
        //    this.Speed = speed;
        //    this.Power = power;
        //}

        //public int Speed
        //{
        //    get { return this.speed; }
        //    set { this.speed = value; }
        //}

        //public int Power
        //{
        //    get { return this.power; }
        //    set { this.power = value; }
        //}
    }
}
