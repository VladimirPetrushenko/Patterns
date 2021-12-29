using System;

namespace Composite.Emails
{
    internal class Email : IEmail
    {
        public string Name { get ; private set ; }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} take message: {message}");
        }

        public Email(string name)
        {
            Name = name;
        }
    }
}
