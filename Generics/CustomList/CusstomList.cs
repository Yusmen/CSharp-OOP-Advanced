using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class CusstomList<T>:IEnumerable<T> where T:IComparable<T>
    {
        private T[] array;
        public int Count { get; private set; }

        public CusstomList()
        {
            array = new T[4];
        }

        public void Add(T element)
        {
            if(this.array.Length==this.Count)
            {
                this.Resize();
            }
            this.array[Count++] = element;
        }

       

        public T Remove(int index)
        {

            T element = array[index];
            array[index] = default(T);
            this.Count--;

            for (int i = index; i < Count; i++)
            {
                array[i] = array[i + 1];
            }

            if(array.Length!=Count)
            {
                array[Count] = default(T);
            }

            return element;


        }

        public  bool Contains(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this.array[i].Equals(element))
                {
                    return true;
                }
               
            }
            return false;
        }
        public void Swap(int firstIndex,int secondIndex)
        {
            T temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;

        }
        public int CountGreaterThan(T element)
        {
            int br = 0;
            for (int i = 0; i < Count; i++)
            {
                if (array[i].CompareTo(element) > 0) 
                {
                    br++;
                }
            }
            return br;
        }
        public T Max()
        {
            T maxValue = array[0];
            for (int i = 1; i < Count; i++)
            {
                if (array[i].CompareTo(maxValue)>0)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }
        public T Min()
        {

            T minValue = array[0];
            for (int i = 1; i < Count; i++)
            {
                if (array[i].CompareTo(minValue) < 0)
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }

        public void Print()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(array[i]);

            }
        }

        private void Resize()
        {
            T[] tempArr = new T[array.Length *2];

            for (int i = 0; i < array.Length; i++)
            {
                tempArr[i] = array[i];
            }
            array = tempArr;
        }
        public void Sort()
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count; j++)
                {
                    if (array[i].CompareTo(array[j])<0)
                    {
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                

                }

            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return array[i];

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
