using System;
using System.Collections.Generic;

namespace Mediator.Chat
{
    class User
    {
        public IChat Chat { get; set; }
        public string Name { get; set; }
        private readonly List<string> chatLog = new List<string>();

        public User(string name) => Name = name;

        public void ReceivingMessage(string sender, string message)
        {
            string s = $"{sender}, message is :{message}";
            if (sender == Chat.Name)
            {
                Console.WriteLine($"{Name} takes message from {sender}: {message}");
            }
            else
            {
                Console.WriteLine($"{this.Name}'s Messanger takes a message from {s}");
            }
            chatLog.Add(s);
        }

        public void PublicMessage(string message) =>
            Chat.Notify(Name, message);

        public void PrivateMessage(string receiver, string message) =>
            Chat.Message(Name, receiver, message);
    }
}
