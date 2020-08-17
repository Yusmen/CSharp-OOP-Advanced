using SollidLogger.Appenders.Contracts;
using SollidLogger.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SollidLogger.Core
{
    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;


        public Engine(ICommandInterpreter commandInterpreter)
        {
           this.commandInterpreter=commandInterpreter ;
        }

        public void Run()
        {


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                this.commandInterpreter.AddAppender(input);

            }

        
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="END")
                {
                    break;
                }

                string[] inputArgs = input.Split('|');

                commandInterpreter.AddMessage(inputArgs);
              
            }
            commandInterpreter.LoggerInfo();

        }
    }
}
