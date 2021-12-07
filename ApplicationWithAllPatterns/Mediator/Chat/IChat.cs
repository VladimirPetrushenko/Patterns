using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Chat
{
    interface IChat
    {
        string Name { get; }
        void Join(User user);
        void Notify(string me, string message);
        void Message(string sender, string receiver, string message);
    }
}
