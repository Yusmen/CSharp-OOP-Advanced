using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main()
        {
            SortedSet<Person> nameSet = new SortedSet<Person>(new NameComparer());
            SortedSet<Person> ageSet = new SortedSet<Person>(new AgeComparator());

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split();
                Person person = new Person(input[0], int.Parse(input[1]));
                nameSet.Add(person);
                ageSet.Add(person);

            }
            Console.WriteLine();

            foreach (var item in nameSet)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in ageSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
