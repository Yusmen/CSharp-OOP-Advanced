using System;
using System.Collections.Generic;
using System.Text;

namespace ComparingObjects
{
    public class Person:IComparable<Person>
    {


        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name,int age,string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public int CompareTo(Person other)
        {
            int resultNames = this.Name.CompareTo(other.Name);

            if (resultNames == 0) 
            {

                int resultAge = this.Age.CompareTo(other.Age);

                if (resultAge == 0) 
                {
                    return this.Town.CompareTo(other.Town);
                }
                return resultAge;

            }
            return resultNames;

            
        }
    }
}
