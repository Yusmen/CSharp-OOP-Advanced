using System;

namespace DesigPatterns
{
    public class PersonPropertyEventArgs : EventArgs
    {

        public string Property { get; set; }

        public object OldValue { get; set; }

        public object NewValue { get; set; }
    }
}
