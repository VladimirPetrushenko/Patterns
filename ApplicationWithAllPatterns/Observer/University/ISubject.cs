using System.Collections.Generic;

namespace Observer.University
{
    interface ISubject
    {
        string Name { get; }
        void Attach(IEnumerable<IObserver> observers);
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message);
    }
}
