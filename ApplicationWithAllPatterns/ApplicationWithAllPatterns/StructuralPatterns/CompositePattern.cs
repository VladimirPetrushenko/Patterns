using Composite;
using TemplateMethod;

namespace ApplicationWithAllPatterns.StructuralPatterns
{
    internal class CompositePattern
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainComposite.Make);
        }
    }
}
