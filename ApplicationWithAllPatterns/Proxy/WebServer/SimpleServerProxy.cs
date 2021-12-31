namespace Proxy.WebServer
{
    internal class SimpleServerProxy : IServer
    {
        private readonly Server server;
        public SimpleServerProxy(Server server)
        {
            this.server = server;
        }

        public void AccessDenied(Client user)
        {
            server.AccessDenied(user);
        }

        public void AccessGranted(Client user)
        {
            server.AccessGranted(user);
        }
    }
}
