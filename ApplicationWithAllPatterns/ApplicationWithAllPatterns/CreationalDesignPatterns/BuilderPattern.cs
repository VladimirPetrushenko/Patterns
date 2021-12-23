using Builder;
using TemplateMethod;

namespace ApplicationWithAllPatterns.CreationalDesignPatterns
{
    class BuilderPattern
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainBuilder.Make);
        }
    }
}
