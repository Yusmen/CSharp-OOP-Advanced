using System;
using System.Collections.Generic;
using System.Text;

namespace KingGambit
{
    public class King : IPerson
    {

        public event EventHandler OnAttack;

        public string Name { get; set; }
        public King(string name)     
        {
            Name = name;
        }


        public void Attack()
        {
            Console.WriteLine($"King {Name} is under attack!");
            OnAttack?.Invoke(this, EventArgs.Empty);
           
        }
    }
}
