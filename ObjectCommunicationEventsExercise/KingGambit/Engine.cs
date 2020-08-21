using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KingGambit
{
    public class Engine
    {

        private King king;
        private List<Soldier> soldiers;

        public Engine()
        {
            soldiers = new List<Soldier>();
        }


        public void Run()
        {
            string kingName = Console.ReadLine();
            king = new King(kingName);

            string[] royalGuargs = Console.ReadLine().Split();


            foreach (var name in royalGuargs)
            {

                Soldier royalGuard = new RoyalGuard(name);
                this.king.OnAttack += royalGuard.KingIsAttacked;

                this.soldiers.Add(royalGuard);
            }
            string[] footMans = Console.ReadLine().Split();


            foreach (var name in footMans)
            {

                Soldier footMan = new Footman(name);
                this.king.OnAttack += footMan.KingIsAttacked;

                this.soldiers.Add(footMan);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split();

                string command = tokens[0];

                if (command == "Attack")
                {
                    this.king.Attack();
                }
                else if (command == "Kill")
                {
                    string soldierName = tokens[1];
                    var soldier = soldiers.FirstOrDefault(x => x.Name == soldierName);
                    this.king.OnAttack -= soldier.KingIsAttacked;
                    this.soldiers.Remove(soldier);

                }
            }
        }
    }
}
