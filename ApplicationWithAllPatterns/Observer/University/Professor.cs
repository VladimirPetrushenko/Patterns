using System;
using System.Collections.Generic;

namespace Observer.University
{
    class Professor : ISubject
    {
        private readonly List<IObserver> students;
        public string Name { get; private set; }

        public Professor(string name)
        {
            students = new List<IObserver>();
            Name = name;
        }
        public void Attach(IEnumerable<IObserver> observers)
        {
            foreach(var observer in observers)
            {
                students.Add(observer);
            }
        }

        public void Attach(IObserver observer)
        {
            students.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            students.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in students)
            {
                observer.Update(this, message);
            }
        }

        public void Make(string lecture)
        {
            Console.WriteLine($"Professor {Name} read {lecture}\n");

            Notify(lecture);

            Console.WriteLine($"\nProfessor {Name} finish reading {lecture}\n");
        }
    }
}
