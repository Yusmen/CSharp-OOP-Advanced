using System;
using System.Collections.Generic;
using System.Text;

namespace DesigPatterns
{
    public class ConsoleWriteLinePersonObserver : IPersonObeserver
    {
        public void Handle(string property)
        {
            Console.WriteLine($"Person changed {property}");
        }

        public void HandleMethod(string method)
        {
            Console.WriteLine($"Method returns:");
        }

    }
}
