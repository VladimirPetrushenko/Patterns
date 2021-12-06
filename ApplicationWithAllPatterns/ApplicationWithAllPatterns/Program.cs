using Strategy;
using System;

namespace ApplicationWithAllPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IStrategy strategy = new FirstExampleStrategy();
            strategy.Make();

            strategy = new SecondExampleStrategy();
            strategy.Make();

            strategy = new ThirdExampleStrategy();
            strategy.Make();
        }
    }
}
