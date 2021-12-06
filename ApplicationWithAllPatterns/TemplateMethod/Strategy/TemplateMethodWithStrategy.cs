using Strategy;
using System;

namespace TemplateMethod.Strategy
{
    public class TemplateMethodWithStrategy : AbstractTemplateMethod
    {
        private readonly IStrategy _strategy;

        public TemplateMethodWithStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        protected override void ToDoSomething()
        {
            _strategy.Make();
        }
    }
}
