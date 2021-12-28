using Facade;
using TemplateMethod;

namespace ApplicationWithAllPatterns.StructuralPatterns
{
    internal class FacadePattern
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainFacade.Make);
        }
    }
}
