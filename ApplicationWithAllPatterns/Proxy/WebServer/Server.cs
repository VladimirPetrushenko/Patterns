using System;

namespace Proxy.WebServer
{
    internal class Server : IServer
    {
        public Server()
        {
            Console.WriteLine("Server was created");
        }
        public void AccessDenied(Client user)
        {
            Console.WriteLine($"Доступ пользователю {user.Id} закрыт");
        }

        public void AccessGranted(Client user)
        {
            Console.WriteLine($"Доступ пользователю {user.Id} открыт");
        }
    }
}
