using System;
using System.Collections.Generic;
using System.Text;

namespace KingGambit
{
    public class RoyalGuard : Soldier
    {
        public RoyalGuard(string name)
            : base(name)
        {
        }

        public override void KingIsAttacked(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {Name} is defending!.");
        }

    }
}
