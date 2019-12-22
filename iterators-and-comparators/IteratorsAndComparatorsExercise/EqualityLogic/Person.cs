using System;
using System.Collections.Generic;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            var comparison = this.Name.CompareTo(other.Name);

            return comparison == 0
                ? this.Age.CompareTo(other.Age)
                : comparison;
        }
    }
}
