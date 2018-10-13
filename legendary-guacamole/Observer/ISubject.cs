using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface ISubject // Or just use System.IObservable for events emission
    {
        void Notify();
        void AddObserver(Observer observer);
        void RemoveObserver(Observer observer);
    }
}
