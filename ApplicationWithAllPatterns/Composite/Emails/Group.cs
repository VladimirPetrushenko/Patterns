using System.Collections.Generic;

namespace Composite.Emails
{
    internal class Group : IEmail
    {
        public Group(string name, params IEmail[] emails)
        {
            Append(emails);
            Name = name;
        }

        private readonly List<IEmail> emails = new List<IEmail>();

        public string Name {get; private set;}

        public void Append(params IEmail[] emails)
        {
            foreach (var email in emails)
            {
                this.emails.Add(email);
            }
        }

        public void Send(string message)
        {
            foreach (var email in emails)
            {
                email.Send(message);
            }
        }
    }
}
