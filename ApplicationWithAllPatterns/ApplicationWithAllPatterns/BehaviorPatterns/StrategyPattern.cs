using Strategy;
using TemplateMethod;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    static class StrategyPattern
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainStrategy.Make);
        }
    }
}
