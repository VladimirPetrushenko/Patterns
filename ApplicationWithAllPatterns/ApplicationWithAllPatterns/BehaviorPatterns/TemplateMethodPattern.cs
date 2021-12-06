using Strategy;
using System;
using TemplateMethod.Strategy;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    static class TemplateMethodPattern
    {
        public static void Make()
        {
            var templateMethod = new TemplateMethodWithStrategy(new FirstExampleStrategy());
            templateMethod.Make();

            templateMethod = new TemplateMethodWithStrategy(new SecondExampleStrategy());
            templateMethod.Make();

            templateMethod = new TemplateMethodWithStrategy(new ThirdExampleStrategy());
            templateMethod.Make();
        }
    }
}
