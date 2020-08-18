using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {

        private T[] elements;
        private int index;

        public ListyIterator(T[] elements)
        {
            this.elements = elements;
            this.index = 0;

        }

        public bool Move()
        {

            index++;
            if (index <= elements.Length - 1)
            {
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (this.index < elements.Length - 1)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            if (this.elements.Length == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(elements[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
    }
}
