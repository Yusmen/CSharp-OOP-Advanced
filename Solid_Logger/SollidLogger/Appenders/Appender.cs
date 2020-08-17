using SollidLogger.Appenders.Contracts;
using SollidLogger.Layouts.Contracts;
using SollidLogger.Loggers.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SollidLogger.Appenders
{
    public abstract class Appender
    {
      

        public ReportLevel ReportLevel { get; set; }
        public int MessagesCount { get; private set; }
        public ILayout Layout { get; }

        public Appender(ILayout layout)
        {
            Layout = layout;
            ReportLevel = new ReportLevel();
        }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);
       
    }
}
