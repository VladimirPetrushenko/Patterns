using Mediator.Chat;
using Mediator.Container.Clients;
using System;

namespace Mediator
{
    public class MainMediator
    {
        public static void Make()
        {
            Console.WriteLine("Pattern Mediator");

            Console.WriteLine("Chat room");
            ChatRoom.Make();

            Console.WriteLine("Calculater");
            Maker.Make();
        }
    }
}
