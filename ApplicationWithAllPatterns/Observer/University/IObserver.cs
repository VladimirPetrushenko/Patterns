namespace Observer.University
{
    interface IObserver
    {
        void Update(ISubject subject, string message);
    }
}
