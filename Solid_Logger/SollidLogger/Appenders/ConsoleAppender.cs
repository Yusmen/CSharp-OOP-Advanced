using SollidLogger.Appenders.Contracts;
using SollidLogger.Layouts.Contracts;
using SollidLogger.Loggers.Enums;
using System;

namespace SollidLogger.Appenders
{
    public class ConsoleAppender : IAppender
    {

        public ILayout Layout { get; }
        public ReportLevel ReportLevel { get; set; }
        public int MessagesCount { get; set; }

        public ConsoleAppender(ILayout layout)
        {
            Layout = layout;
            ReportLevel = new ReportLevel();
        }

       

        public void Append(string dateTime,ReportLevel errorLevel,string message)
        {
            if (errorLevel >= this.ReportLevel) 
            {
                this.MessagesCount++;
                Console.WriteLine(string.Format(this.Layout.Format, dateTime, errorLevel, message));
            }
          
            
        }
        
        public override string ToString()
        {
            return $"Appender type: ConsoleAppender, Layout type: {this.Layout.GetType().Name}, Report level: {ReportLevel}, Messages appended: {MessagesCount}";
        }
    }
}
