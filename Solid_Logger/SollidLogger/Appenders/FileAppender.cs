using SollidLogger.Appenders.Contracts;
using SollidLogger.Layouts.Contracts;
using SollidLogger.Loggers;
using SollidLogger.Loggers.Enums;
using System.IO;

namespace SollidLogger.Appenders
{
    public class FileAppender : IAppender
    {
        private const string path = "log.txt";
        public ILayout Layout { get; }
        public ILogFile Logfile { get; }
        public ReportLevel ReportLevel { get; set; }
        public int MessagesCount { get; set; }

        public FileAppender(ILayout layout)
        {
            Layout = layout;
            Logfile = new LogFile();
        }

        public FileAppender(ILayout layout,ILogFile logfile)
        {
            Layout = layout;
            Logfile = logfile;
        }

       

        public void Append(string dateTime, ReportLevel errorLevel, string message)
        {
            if(errorLevel>=this.ReportLevel)
            {
                MessagesCount++;
                string content = string.Format(this.Layout.Format, dateTime, errorLevel, message);
                Logfile.Write(content);
                File.AppendAllText(path, content);
            }
          
        }
        public override string ToString()
        {
            return $"Appender type: FileAppender, Layout type: {this.Layout.GetType().Name}, Report level: {ReportLevel}, Messages appended: {MessagesCount},File size: {Logfile.Size}";
        }
    }
}
