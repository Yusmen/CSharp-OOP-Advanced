using System;

namespace EqualityLogic
{
    public class Person:IComparable<Person>
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public override bool Equals(object obj)
        {

            if (obj is Person person) 
            {
                return this.Name == person.Name && this.Age == person.Age;
            }
            return false;
           
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode();
        }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result == 0) 
            {
                return this.Age.CompareTo(other.Age);
            }
            return result;
        }
    }
}
