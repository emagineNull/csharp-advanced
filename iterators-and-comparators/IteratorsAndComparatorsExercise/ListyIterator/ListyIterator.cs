using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private const int CurrentInternalIndexInitialValue = 0;

        public List<T> items;
        private int currentInternalIndex;

        public ListyIterator() 
        {
            this.items = new List<T>();
            this.currentInternalIndex = CurrentInternalIndexInitialValue;
        }

        public ListyIterator(IEnumerable<T> collectionData)
        {
            this.items = new List<T>(collectionData);

        }

        public bool Move()
        {
            if (this.currentInternalIndex < this.items.Count - 1)
            {
                this.currentInternalIndex++;
            }
            else
            {
                return false;
            }

            return true;
        }

        public bool HasNext()
        {
            if (this.currentInternalIndex < this.items.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T Print()
        {
            if (this.items.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            return this.items[this.currentInternalIndex];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
