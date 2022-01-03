using System;

namespace Proxy.WebServer
{
    internal class LazyServerProxy : IServer
    {
        private readonly Lazy<Server> server;
        public LazyServerProxy()
        {
            server = new Lazy<Server>(() => new Server());
        }

        public void AccessDenied(Client user)
        {
            server.Value.AccessDenied(user);
        }

        public void AccessGranted(Client user)
        {
            server.Value.AccessGranted(user);
        }
    }
}
