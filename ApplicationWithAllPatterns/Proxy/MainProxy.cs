using Proxy.WebServer;
using System;

namespace Proxy
{
    public class MainProxy
    {
        public static void Make()
        {
            Console.WriteLine("Pattern Proxy\n");

            var server = new Server();
            var proxy = new SimpleServerProxy(server);
            var user = new Client();

            proxy.AccessDenied(user);
            proxy.AccessGranted(user);

            Console.WriteLine("Вызов конструктора Lazy");
            var lazyProxy = new LazyServerProxy();

            Console.WriteLine("Вызов первого метода");
            lazyProxy.AccessGranted(user);

            var guardProxy = new GuardServerProxy();

            user.Id = "#2021";
            Console.WriteLine("User.id = #2021");
            guardProxy.AccessGranted(user);
         
            user.Id = "#2022";
            Console.WriteLine("User.id = #2022");
            guardProxy.Authorization(user);
        }
    }
}
