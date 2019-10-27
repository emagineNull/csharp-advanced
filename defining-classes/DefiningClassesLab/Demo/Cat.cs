using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Cat
    {
        private string name;

        public int Age { get; private set; }

        public bool IsAsleep { get; private set; }

        public Owner Owner { get; private set; }
        
        public void GoToSleep()
        {
            this.IsAsleep = true;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Cat name should be more than one symbol.");
                }

                this.name = value;
            }
        }

        public string SayHello()
        {
            return $"Meow! {this.name}";
        }
    }
}
