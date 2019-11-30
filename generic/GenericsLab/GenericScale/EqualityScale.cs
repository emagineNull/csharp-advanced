using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericScale
{
    public class EqualityScale<T> where T : IComparable<T>
    {
        private T right;
        private T left;

        public EqualityScale(T left, T right)
        {
            this.right = right;
            this.left = left;
        }

        public T AreEqual()
        {
            var comparison = left.CompareTo(right);

            if (comparison > 0)
            {
                return left;
            }
            else if (comparison < 0)
            {
                return right;
            }

            return default(T);
        }
    }
}
