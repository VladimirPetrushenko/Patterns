using Decorator;
using TemplateMethod;

namespace ApplicationWithAllPatterns.StructuralPatterns
{
    internal class DecoratorPattern
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainDecorator.Make);
        }
    }
}
