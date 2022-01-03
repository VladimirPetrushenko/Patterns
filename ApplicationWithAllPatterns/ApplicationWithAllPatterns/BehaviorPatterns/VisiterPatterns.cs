using TemplateMethod;
using Visitor;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    static class VisiterPatterns
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainVisitor.Make);
        }
    }
}
