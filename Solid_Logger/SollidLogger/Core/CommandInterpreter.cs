using SollidLogger.Appenders.Contracts;
using SollidLogger.Appenders.Factory;
using SollidLogger.Core.Contracts;
using SollidLogger.Layouts.Contracts;
using SollidLogger.Layouts.Factory;
using SollidLogger.Layouts.Factory.Contracts;
using SollidLogger.Loggers.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SollidLogger.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private IAppenderFactory appenderFactory;
        private ILayoutFactory layoutFactory;
        public CommandInterpreter()
        {
            appenders = new List<IAppender>();
            appenderFactory = new AppenderFactory();
            layoutFactory = new LayoutFactory();

        }

        public void AddAppender(string[] args)
        {
            string appenderType = args[0];
            string layoutType = args[1];
            ReportLevel reportLevel = ReportLevel.Info;

            if (args.Length == 3)
            {
                reportLevel = Enum.Parse<ReportLevel>(args[2],true);

            }
            ILayout layout = this.layoutFactory.CreateLayout(layoutType);
            IAppender appender = this.appenderFactory
                .CreateAppender(appenderType,layout);

            appender.ReportLevel = reportLevel;
            appenders.Add(appender);
        }

        public void AddMessage(string[] args)
        {
            ReportLevel report = Enum.Parse<ReportLevel>(args[0],true);
            string dateTime = args[1];
            string message = args[2];

            foreach (var appender in appenders)
            {
                appender.Append(dateTime, report, message);
            }
        }

        public void LoggerInfo()
        {
            Console.WriteLine("Logger Info");

            foreach (var appender in appenders)
            {
                Console.WriteLine(appender);

            }
        }
    }
}
