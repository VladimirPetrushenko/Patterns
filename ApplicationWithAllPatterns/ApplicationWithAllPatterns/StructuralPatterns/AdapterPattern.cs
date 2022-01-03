using Adapter;
using TemplateMethod;

namespace ApplicationWithAllPatterns.StructuralPatterns
{
    class AdapterPattern
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainAdapter.Make);
        }
    }
}
