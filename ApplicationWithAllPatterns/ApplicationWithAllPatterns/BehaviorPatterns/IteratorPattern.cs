using Iterator;
using System;
using TemplateMethod;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    static class IteratorPattern
    {
        public static void Make()
        {
            foreach(var f in Fibonacci.GenerateFibonacci(25))
            {
                Console.Write($"{f} ");
            }
            Console.WriteLine();
        }

        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(Make);
        }
    }
}
