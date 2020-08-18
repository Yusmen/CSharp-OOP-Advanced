using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {

        private List<T> elemets;
        public int Count { get; set; }

        public CustomStack()
        {
            this.elemets = new List<T>();
        }


        public void Push(params T[] itemsToAdd)
        {
            elemets.AddRange(itemsToAdd);
        }

        public T Pop()
        {
            if (elemets.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            T element = elemets[elemets.Count - 1];
            elemets.RemoveAt(elemets.Count - 1);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = elemets.Count - 1; i >= 0; i--)
            {
                yield return elemets[i];

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
       => GetEnumerator();
    }
}
