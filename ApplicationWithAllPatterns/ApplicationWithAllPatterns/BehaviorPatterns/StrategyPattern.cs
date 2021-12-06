using Strategy;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    static class StrategyPattern
    {
        public static void Make() {
            IStrategy strategy = new FirstExampleStrategy();
            strategy.Make();

            strategy = new SecondExampleStrategy();
            strategy.Make();

            strategy = new ThirdExampleStrategy();
            strategy.Make();
        }
    }
}
