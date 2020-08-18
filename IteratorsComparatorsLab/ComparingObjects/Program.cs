using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();

            while (true)
            {

                string input = Console.ReadLine();
                if (input=="END")
                {
                    break;
                }
                string[] tokens = input.Split();
                Person person = new Person(tokens[0],int.Parse(tokens[1]), tokens[2]);
                people.Add(person);


            }
            int personNumber = int.Parse(Console.ReadLine());

            Person currentPerson = people[personNumber - 1];

            int equalPeople = 0;
            int notEqualPeople = 0;

            for (int i = 0; i < people.Count; i++)
            {
                if (currentPerson.CompareTo(people[i])==0)
                {
                    equalPeople++;

                }
                else
                {
                    notEqualPeople++;
                }
            }

            if (equalPeople>1)
            {
                Console.WriteLine($"{equalPeople} {notEqualPeople} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches!");
            }
        }
    }
}
