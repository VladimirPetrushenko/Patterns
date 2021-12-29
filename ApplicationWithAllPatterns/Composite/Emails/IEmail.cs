namespace Composite.Emails
{
    internal interface IEmail
    {
        void Send(string message);
        public string Name { get; }
    }
}
