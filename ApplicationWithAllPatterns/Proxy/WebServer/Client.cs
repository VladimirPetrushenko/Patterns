namespace Proxy.WebServer
{
    internal class Client
    {
        private string id;
        public string Id { get { return id; } set { id = value; } }
        public Client()
        {
            this.id = "#2022";
        }
    }
}
