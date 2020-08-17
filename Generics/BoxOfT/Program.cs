using System;
using System.Collections.Generic;

namespace BoxOfT
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
            }

            double element =double.Parse( Console.ReadLine());
            // Swap(box.List, int.Parse(indexes[0]), int.Parse(indexes[1]));
            Console.WriteLine(box.GetGreater(element));
 
  
         
        }

        private static void Swap<T>(List<T> list,int index1,int index2)
        {
            T temp=default(T);
            temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;

        }
      
    }
}
