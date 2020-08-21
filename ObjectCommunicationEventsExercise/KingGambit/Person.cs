using System;
using System.Collections.Generic;
using System.Text;

namespace KingGambit
{
    public class Person : IPerson
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        
    }
}
