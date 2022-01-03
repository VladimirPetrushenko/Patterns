using TemplateMethod;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    static class TemplateMethodPattern
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainTemplateMethod.Make);
        }
    }
}
