using System;

namespace Iterator
{
    public class MainIterator
    {
        public static void Make()
        {
            Console.WriteLine("Pattern Iterator");
            foreach (var f in Fibonacci.GenerateFibonacci(25))
            {
                Console.Write($"{f} ");
            }
            Console.WriteLine();
        }
    }
}
