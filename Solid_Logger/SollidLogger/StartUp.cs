using SollidLogger.Appenders;
using SollidLogger.Core;
using SollidLogger.Core.Contracts;
using SollidLogger.Layouts;
using SollidLogger.Loggers;
using SollidLogger.Loggers.Enums;

namespace SollidLogger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter command = new CommandInterpreter();
            IEngine engine = new Engine(command);
            engine.Run();



        }
    }
}
