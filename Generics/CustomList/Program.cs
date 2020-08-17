using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            CusstomList<string> cusstomList = new CusstomList<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="END")
                {
                    break;
                }

                string[] tokens = input.Split();
                string command = tokens[0];


                if (command == "Add")
                {
                    string element = tokens[1];
                    cusstomList.Add(element);
                }
                else if (command == "Remove")
                {
                    Console.WriteLine(cusstomList.Remove(int.Parse(tokens[1])));
                }
                else if (command == "Contains")
                {
                    Console.WriteLine(cusstomList.Contains(tokens[1]));
                }
                else if (command == "Swap")
                {
                    cusstomList.Swap(int.Parse(tokens[1]), int.Parse(tokens[2]));
                }
                else if (command == "Greater")
                {
                    Console.WriteLine(cusstomList.CountGreaterThan(tokens[1]));
                }
                else if (command == "Max")
                {
                    Console.WriteLine(cusstomList.Max());
                }
                else if (command == "Min")
                {
                    Console.WriteLine(cusstomList.Min());

                }
                else if (command == "Print")
                {
                    foreach (var item in cusstomList)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (command == "Sort") 
                {
                    cusstomList.Sort();
                }
                  
            }
        }
    }
}
