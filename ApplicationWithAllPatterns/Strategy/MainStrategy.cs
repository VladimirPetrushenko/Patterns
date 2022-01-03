using System;

namespace Strategy
{
    public class MainStrategy
    {
        public static void Make()
        {
            Console.WriteLine("Pattern Strategy");
            IStrategy strategy = new FirstExampleStrategy();
            strategy.Make();

            Console.WriteLine();
            strategy = new SecondExampleStrategy();
            strategy.Make();

            Console.WriteLine();
            strategy = new ThirdExampleStrategy();
            strategy.Make();
        }
    }
}
