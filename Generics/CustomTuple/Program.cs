using System;

namespace CustomTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();

            string name = firstLine[0] + firstLine[1];
            SpecialTuple<string, string,string> firstTuple = new SpecialTuple<string, string,string>(name, firstLine[2],firstLine[3]);

            string[] secondLine = Console.ReadLine().Split();
            bool IsDrunk = false;
            if(secondLine[2].ToLower()=="drunk")
            {
                IsDrunk = true;
            }
            SpecialTuple<string, int,bool> secondTuple =new SpecialTuple<string, int,bool>(secondLine[0], int.Parse(secondLine[1]),IsDrunk);
            string[] thirdLine = Console.ReadLine().Split();



           SpecialTuple<string, double,string> tuple = new SpecialTuple<string,double,string>(thirdLine[0],double.Parse(thirdLine[1]),thirdLine[2]);


            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(tuple);
        }
    }
}
