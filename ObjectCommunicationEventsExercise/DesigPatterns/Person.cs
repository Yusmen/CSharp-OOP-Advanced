using System;
using System.Collections;
using System.Collections.Generic;

namespace DesigPatterns
{
    public class Person
    {

        private string firstName;
        private string lastName;

        private ICollection<IPersonObeserver> observers = new List<IPersonObeserver>();

        public event EventHandler<PersonPropertyEventArgs> OnPropertyChanged;
        public event EventHandler OnGreeting;

        public string LastName
        {
            get => lastName;
            set
            {
                this.OnPropertyChanged?.Invoke(this, new PersonPropertyEventArgs()
                {
                    Property = nameof(LastName),
                    OldValue = lastName,
                    NewValue = value
                });
                this.NotifyObservers(nameof(LastName));
                lastName = value;

            }
        }


        public string FirstName
        {
            get { return firstName; }
            set
            {
                this.OnPropertyChanged?.Invoke(this, new PersonPropertyEventArgs()
                {
                    Property = nameof(FirstName),
                    OldValue = firstName,
                    NewValue = value

                });

                this.NotifyObservers(nameof(FirstName));

                firstName = value;

            }
        }

        public void AddObserver(IPersonObeserver observer)
        {
            observers.Add(observer);
        }

        public string SayHello()
        {
            this.OnGreeting?.Invoke(this, EventArgs.Empty);
            this.NotifyObservers(nameof(SayHello));
            return $"My name is {FirstName} {LastName}";
        }

        private void NotifyObservers(string method)
        {

            foreach (var observer in observers)
            {
                observer.HandleMethod(method);
            }

        }

    }
}
