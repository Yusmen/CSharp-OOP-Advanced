using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Fisrt
{
    public class Program
    {
        public static void Main()
        {

            var catMethods = typeof(Cat).GetMethods();

            foreach (var method in catMethods)
            {
                if (!method.IsSpecialName && method.DeclaringType == typeof(Cat) && method.IsStatic)
                {

                    var result = method.Invoke(null, new object[0]);

                    Console.WriteLine(result);
                }

            }




        }
    }
}
