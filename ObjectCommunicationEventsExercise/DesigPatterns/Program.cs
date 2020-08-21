using System;

namespace DesigPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                FirstName = "Ivan",
                LastName = "Ivanov"
            };

            person.OnPropertyChanged += (human, eventData) =>
            {
                Console.WriteLine($"{eventData.Property} " +
                    $"changed from {eventData.OldValue} to" +
                    $" {eventData.NewValue}");
            };
            person.AddObserver(new ConsoleWriteLinePersonObserver());

            Console.WriteLine(person.SayHello());





        }
    }
}
