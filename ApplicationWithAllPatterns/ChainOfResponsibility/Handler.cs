namespace ChainOfResponsibility
{
    abstract class Handler
    {
        protected readonly Chain _next;

        protected Handler(Chain next)
        {
            _next = next;
        }

        public abstract void Make(int context); 
    }
}
