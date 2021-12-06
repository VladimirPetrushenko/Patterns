using Strategy;
using System;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    static class StrategyPattern
    {
        public static void Make() {
            Console.WriteLine("start first strategy");
            IStrategy strategy = new FirstExampleStrategy();
            strategy.Make();
            Console.WriteLine("End");

            Console.WriteLine("Start second strategy");
            strategy = new SecondExampleStrategy();
            strategy.Make();
            Console.WriteLine("End");

            Console.WriteLine("Start third strategy");
            strategy = new ThirdExampleStrategy();
            strategy.Make();
            Console.WriteLine("End");
        }
    }
}
