using System;
using System.Collections.Generic;
using System.Text;

namespace SollidLogger.Loggers.Contracts
{
    public interface ILogger
    {
        void Error(string dateTime,string errorMessage);

        void Info(string dateTime, string infoMessage);
    }
}
