using System.Linq;
using System;

namespace ArtributeCreate
{
    [Info("Pesho",3, "Used for C# OOP Advanced Course " +
        "- Enumerations and Attributes.","Pesho","Svetlio")]
    public class Program
    {
        public static void Main(string[] args)
        {
            var attribute = (InfoAttribute)typeof(Program)
                .GetCustomAttributes(false)
                .First();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="END")
                {
                    break;
                }


                if (input == "Author") 
                {
                    Console.WriteLine($"Author: {attribute.Author}");
                }
                else if (input == "Revision")
                {
                    Console.WriteLine($"Revision: {attribute.Revision}");
                }
                else if (input == "Reviewers") 
                {
                    Console.WriteLine($"Revievers: {string.Join(", ",attribute.Reviewers)}");
                }
                else if (input=="Description")
                {
                    Console.WriteLine($"Description: {attribute.Description}");
                }
                    
                    
            }
        }
    }
}
