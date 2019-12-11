using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodIntegers
{
    public class Box<T>
    {
        private List<T> values;

        public Box()
        {
            this.values = new List<T>();
        }

        public void Add(T value)
        {
            this.values.Add(value);
        }

        public void Swap(int x, int y)
        {
            T temp = this.values[x];
            this.values[x] = this.values[y];
            this.values[y] = temp;
        }

        public void Printer()
        {
            foreach (var item in this.values)
            {
                Console.WriteLine($"{item.GetType().FullName}: {item.ToString()}");
            }
        }
    }
}
