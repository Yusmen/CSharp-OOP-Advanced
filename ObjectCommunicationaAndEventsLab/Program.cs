using System;

namespace Object_Communication_and_Events_Lab
{
    public class Program
    {
        public static void Main()
        {
            CombatLogger combatLogger = new CombatLogger();

            combatLogger.Handle(LogType.ATTACK, "Joined");
          
        }
    }
}
