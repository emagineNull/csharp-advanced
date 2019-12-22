using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private T[] values;
        private int count;

        public Stack(int initCap)
        {
            this.values = new T[initCap];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Push(T value)
        {
            if (this.count == this.values.Length)
            {
                var nextValues = new T[this.values.Length * 2];
                for (int i = 0; i < this.values.Length; i++)
                {
                    nextValues[i] = this.values[i];
                }

                this.values = nextValues;
            }
            this.values[this.count] = value;
            this.count++;
        }

        public void Pop()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            
            this.values = this.values.Take(this.values.Length - 1).ToArray();
            this.count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.values.Length; i++)
            {
                yield return this.values[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
