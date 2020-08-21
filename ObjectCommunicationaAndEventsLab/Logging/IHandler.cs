
using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Communication_and_Events_Lab
{
    public interface IHandler
    {

        void Handle(LogType type, string message);

        void SetSuccessor(IHandler handler);

    }



}
