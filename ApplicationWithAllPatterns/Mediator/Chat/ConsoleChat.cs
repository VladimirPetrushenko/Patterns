using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator.Chat
{
    class ConsoleChat : IChat
    {
        public string Name { get; private set; }
        public List<User> Users { get; set; } = new List<User>();
        
        public ConsoleChat(string name)
        {
            Name = $"\n{name}";
        }

        public void Join(User user)
        {
            Notify(Name, $"User - {user.Name} has joined us");
            user.Chat = this;
            Users.Add(user);
        }

        public void Notify(string me, string message) 
        { 
            Users.Where(u => u.Name != me)
                .ToList()
                .ForEach(u => u.ReceivingMessage(me, message));
            Console.WriteLine();
        }
        public void Message(string me, string receiver, string message) =>
            Users.FirstOrDefault(u => u.Name == receiver)
                ?.ReceivingMessage(me, message);
    }
}
