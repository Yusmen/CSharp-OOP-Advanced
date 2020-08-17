using SollidLogger.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SollidLogger.Layouts.Factory.Contracts
{
    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}
