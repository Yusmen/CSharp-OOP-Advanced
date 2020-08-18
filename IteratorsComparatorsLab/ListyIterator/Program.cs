using System;
using System.Linq;

namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split().Skip(1).ToArray();

            ListyIterator<string> list = new ListyIterator<string>(elements);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split();

                string command = tokens[0];

                if (command == "Move")
                {
                    Console.WriteLine("->" + list.Move());
                }
                else if (command == "Print")
                {

                    list.Print();
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine("->" + list.HasNext());

                }
                else if (command == "PrintAll")
                {
                    foreach (var item in list)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }


            }
        }
    }
}
