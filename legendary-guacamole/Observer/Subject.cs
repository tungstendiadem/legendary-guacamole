using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    internal class Subject : ISubject
    {
        public Subject()
        {
        }

        public void AddObserver(Observer observer)
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            foreach (var o in observers)
            {
                o.ReceiveUpdate();
            }
        }

        public void RemoveObserver(Observer observer)
        {
            throw new NotImplementedException();
        }

        private readonly List<Observer> observers = new List<Observer>();

        public List<Observer> Observering { get => Observering; set => Observering = value; }

        public List<Observer> Observers1 => Observers1;

        public List<Observer> Observers2
        {
            get
            {
                return Observers2;
            }
        }
    }
}
