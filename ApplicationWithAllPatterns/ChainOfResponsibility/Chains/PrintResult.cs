using System;

namespace ChainOfResponsibility.Chains
{
    class PrintResult : Handler
    {
        private static int count = 0;
        public PrintResult(Chain next) : base(next)
        {
        }

        public override void Make(int context)
        {
            Console.WriteLine("\nI am in PrintResult");
            Console.WriteLine("result is " + context);
            Console.WriteLine($"\nPrinter {context} {count}");
            count++;

            _next(context);
            count--;

            Console.WriteLine($"\nPrinter {context} {count}");
        }
    }
}
