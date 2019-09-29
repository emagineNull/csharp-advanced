using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> someStack = new Stack<int>();

            someStack.Push(1);   // 1 2 100
            someStack.Push(2);
            someStack.Push(100);

            Console.WriteLine(someStack.Count);

            Console.WriteLine(someStack.Peek());
            Console.WriteLine(someStack.Pop());

            Console.WriteLine(someStack.Count);


            Stack<string> mivka = new Stack<string>();

            mivka.Push("Salata");
            mivka.Push("Kartofi");
            mivka.Push("Torta");

            while (mivka.Any())
            {
                Console.WriteLine(mivka.Pop());
            }

            HashSet<int> numbers = new HashSet<int>();

            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            Stack<int> chisla = new Stack<int>();

            chisla.Push(1);
            chisla.Push(2);

            Console.WriteLine(chisla.Contains(2));
            Console.WriteLine(chisla.ToList());


            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);


        }
    }
}
