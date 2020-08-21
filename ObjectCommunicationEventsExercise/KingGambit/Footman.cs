using System;
using System.Collections.Generic;
using System.Text;

namespace KingGambit
{
    public class Footman : Soldier
    {
        public Footman(string name) 
            : base(name)
        {
        }


        public override void KingIsAttacked(object sender,EventArgs args)
        {
            Console.WriteLine($"Footman {Name} is panicking!.");
        }
    }
}
