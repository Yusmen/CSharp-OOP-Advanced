using System;
using System.Collections.Generic;
using System.Text;

namespace EventImplementation
{
   // public delegate void NameChangeEventHandler(object sender,NameChangeEventArgs args);

    public class Dispatcher
    {

        private string name;

        public event EventHandler<NameChangeEventArgs> NameChange;

        public string Name
        {
            get { return name; }

            set
            {
                name = value;
                OnNameChange(new NameChangeEventArgs(value));
          
            }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
            NameChange.Invoke(this, args);
            
        }

    }
}
