using System;
using System.Linq;

namespace Stack
{
    public class Program
    {
        public static void Main()
        {
            CustomStack<string> stack = new CustomStack<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] tokens = input
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                if (command == "Push")
                {
                    tokens = tokens.Skip(1).ToArray();
                    stack.Push(tokens);
                }
                else if (command == "Pop")
                {
                    stack.Pop();
                }

            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
