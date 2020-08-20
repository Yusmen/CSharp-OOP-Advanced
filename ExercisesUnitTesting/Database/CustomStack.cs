using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Database
{
    public class CustomStack
    {
        private const int size = 16;
        private int[] collection;
        private int index;

        public CustomStack()
        {
            collection = new int[size];
            index = -1;
        }

        public CustomStack(int[] values)
        {
            if (values.Length > 16) 
            {
                throw new InvalidOperationException("The length have to be 16 integers");
            }

            collection = values;
            index = values.Length - 1;
        }

        public void Add(int number)
        {
            if (this.index + 1 < size)  
            {
                
                this.collection[++index] = number;
                return;
            }
            throw new InvalidOperationException("Collection is full");
        }

        public void Remove()
        {
            if (index == -1) 
            {
                throw new InvalidOperationException("Collection is empty!");
            }
            collection[index] = 0;
            index--;
        }

        public int[] Fetch()
        {
            return this.collection.Take(index + 1).ToArray();
        }
    }
}
