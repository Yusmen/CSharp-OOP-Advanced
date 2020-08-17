using System;
using System.Collections.Generic;
using System.Text;

namespace SollidLogger.Core.Contracts
{
    public interface ICommandInterpreter
    {
        void AddAppender(string[] args);

        void AddMessage(string[] args);

        void LoggerInfo();

     
    }
}
