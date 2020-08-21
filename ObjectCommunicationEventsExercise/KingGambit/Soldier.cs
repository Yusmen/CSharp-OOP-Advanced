using System;
using System.Collections.Generic;
using System.Text;

namespace KingGambit
{
    public abstract class Soldier : IPerson
    {
        public Soldier(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public abstract void KingIsAttacked(object sender, EventArgs args);

    }
}
