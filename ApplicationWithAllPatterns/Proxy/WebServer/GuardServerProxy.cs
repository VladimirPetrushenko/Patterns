using System;

namespace Proxy.WebServer
{
    internal class GuardServerProxy : IServer
    {
        private Lazy<Server> server;

        public void AccessDenied(Client user)
        {
            if(server == null)
            {
                Console.WriteLine("Пользователь отсутствует");
            }
            else
            {
                server.Value.AccessDenied(user);
            }
        }

        public void AccessGranted(Client user)
        {
            if(server == null)
            {
                Console.WriteLine("Пользователь отсутствует");
            }
            else
            {
                server.Value.AccessGranted(user);
            }
        }

        public void Authorization(Client user)
        {
            if(user.Id == "#2022")
            {
                server = new Lazy<Server>(() => new Server());
                AccessGranted(user);
            }
        }
    }
}
