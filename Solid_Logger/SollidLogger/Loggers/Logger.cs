using System;
using SollidLogger.Appenders.Contracts;
using SollidLogger.Loggers.Contracts;
using SollidLogger.Loggers.Enums;

namespace SollidLogger.Loggers
{
    public class Logger : ILogger
    {
        public IAppender ConsoleAppender { get; }
        public IAppender FileAppender { get; }
        public Logger(IAppender consoleAppender)
        {
            this.ConsoleAppender = consoleAppender;

        }

        public Logger(IAppender consoleAppender, IAppender fileAppender)
        {
            this.ConsoleAppender = consoleAppender;

            FileAppender = fileAppender;
        }

        public  void Warning(string dateTime, string warningMessage)
        {
            this.AppendMessage(dateTime, ReportLevel.Warning, warningMessage);
        }

        public  void Critical(string dateTime, string criticalMessage)
         {

            this.AppendMessage(dateTime, ReportLevel.Critical, criticalMessage);
           
         }

        public  void Fatal(string dateTime, string fatalMessage)
        {
            this.AppendMessage(dateTime, ReportLevel.Fatal, fatalMessage);

        }

        public void Error(string dateTime, string errorMessage)
        {
            this.AppendMessage(dateTime, ReportLevel.Error, errorMessage);
        }

        public void Info(string dateTime, string infoMessage)
        {
            this.AppendMessage(dateTime, ReportLevel.Info, infoMessage);
        }

        private void AppendMessage(string dateTime, ReportLevel reportLevel, string criticalMessage)
        {
            this.ConsoleAppender?.Append(dateTime, reportLevel, criticalMessage);
            this.FileAppender?.Append(dateTime, reportLevel, criticalMessage);
        }
    }

        
    
}
