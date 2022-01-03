using Mediator;
using TemplateMethod;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    static class MediatorPattern
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainMediator.Make);
        }
    }
}
