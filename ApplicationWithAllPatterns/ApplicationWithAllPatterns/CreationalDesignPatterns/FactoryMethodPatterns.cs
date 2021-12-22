using FactoryMethod;
using TemplateMethod;

namespace ApplicationWithAllPatterns.CreationalDesignPatterns
{
    class FactoryMethodPatterns
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainFactoryMethod.Make);
        }
    }
}
