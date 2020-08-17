using SollidLogger.Appenders.Contracts;
using SollidLogger.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SollidLogger.Appenders.Factory
{
    public interface IAppenderFactory
    {

        IAppender CreateAppender(string type,ILayout layout);
    }
}
