using Iterator;
using TemplateMethod;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    static class IteratorPattern
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainIterator.Make);
        }
    }
}
