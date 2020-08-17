using System;

namespace Generic
{
    public class GenericScale<T> where T: IComparable<T>
    {

        private T left;
        private T right;

        public GenericScale(T left,T right)
        {
            this.left = left;
            this.right = right;
        }

        public T GetHeavier()
        {
            if (left.CompareTo(right) > 0)
            {
                return left;
            }
            else if (left.CompareTo(right) < 0) 
            {
                return right;
            }
            return default(T);
           
        }
            
    }
}
