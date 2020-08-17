using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxOfT
{
    public class Box<T> where T:IComparable<T>
    {
        
        private List<T> list;

        public List<T> List
        {
            get { return list; }
            set { list = value; }
        }


        public Box()
        {
            list = new List<T>();
        }
        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove()
        {
            var result = list.Last();
            list.RemoveAt(this.list.Count - 1);
            return result;

        }

        public int Count()
        {
            return list.Count;
        }

        public int GetGreater(T element)
        {
            int br = 0;
            foreach (var item in List)
            {
                if (item.CompareTo(element) > 0) 
                {
                    br++;
                }
            }
            return br;
        }


        public override string ToString()
        {
            return $"{typeof(T)}:{list[2]}";
        }
    }
}
