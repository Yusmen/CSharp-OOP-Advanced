using System;

namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GenericScale<double> scale = new GenericScale<double>(2.5,10.81654);

            Console.WriteLine(scale.GetHeavier());
        }
    }
}
