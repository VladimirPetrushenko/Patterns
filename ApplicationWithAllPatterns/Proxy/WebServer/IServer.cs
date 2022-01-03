namespace Proxy.WebServer
{
    internal interface IServer
    {
        void AccessDenied(Client user);
        void AccessGranted(Client user);
    }
}
