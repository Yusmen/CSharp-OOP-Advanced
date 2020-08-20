using System;
using System.Collections.Generic;
using System.Text;

namespace Fisrt
{
    public class Cat : Animal
    {

      
        public Cat(string name,int age) 
            : base(name,age)
        {
        }

        public void SayHello()
        {
            Console.WriteLine("Hello!!");
        }

        public static string StaticMethod()
        {
            return $"Static!!";
        }


       
    }
}
