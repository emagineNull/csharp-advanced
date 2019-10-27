using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            cat.Name = "Pesho";

            cat.Name = "Ivan";

            Console.WriteLine(cat.Name);

            var owner = new Owner();
            owner.Name = "Bai Ivan";

            owner.Cats.Add(cat);
        }
    }
}
