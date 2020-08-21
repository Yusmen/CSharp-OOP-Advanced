using System;
using System.Collections.Generic;
using System.Text;

namespace DesigPatterns
{
    public interface IPersonObeserver
    {

        void Handle(string property);
        void HandleMethod(string method);
            
    }
}
