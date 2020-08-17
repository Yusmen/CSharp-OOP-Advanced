using SollidLogger.Loggers.Enums;

namespace SollidLogger.Appenders.Contracts
{
    public interface IAppender
    {

        void Append(string dateTime, ReportLevel errorLevel, string message);

        ReportLevel ReportLevel { get; set; }

        int MessagesCount { get; set; }
    }
}
