using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class NameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int firstResult = x.Name.Length.CompareTo(y.Name.Length);
            if (firstResult == 0)
            {
                int letterX = x.Name[0];
                int letterY = y.Name[0];
                return letterX.CompareTo(letterY);
            }
            return firstResult;
        }
    }
}
