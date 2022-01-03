using Observer;
using TemplateMethod;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    static class ObserverPattern
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainObserver.Make);
        }
    }
}
