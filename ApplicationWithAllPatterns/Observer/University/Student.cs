using System;

namespace Observer.University
{
    class Student : IObserver
    {
        public string Name { get; private set; }

        public Student(string name)
        {
            Name = name;
        }

        public void Update(ISubject subject, string message)
        {
            Console.WriteLine($"Student {Name} write down {message} read by professor {subject.Name}");
        }
    }
}
