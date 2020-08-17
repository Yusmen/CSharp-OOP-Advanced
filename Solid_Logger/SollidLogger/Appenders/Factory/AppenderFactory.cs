using System;
using System.Collections.Generic;
using System.Text;
using SollidLogger.Appenders.Contracts;
using SollidLogger.Layouts.Contracts;

namespace SollidLogger.Appenders.Factory
{
    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            string typeTolower = type.ToLower();

            switch (typeTolower)
            {
                case "consoleappender":return new ConsoleAppender(layout);
                case "fileappender":return new FileAppender(layout);
                default:
                    throw new ArgumentException("Invalid argument type");
            }
        }
    }
}
