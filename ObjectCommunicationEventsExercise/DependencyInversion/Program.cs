using P03_DependencyInversion;
using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(new PrimitiveCalculator());
            engine.Run();

            
        }
    }
}
