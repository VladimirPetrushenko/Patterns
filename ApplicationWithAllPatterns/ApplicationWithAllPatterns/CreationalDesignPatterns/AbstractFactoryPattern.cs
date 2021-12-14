using AbstractFactory;
using TemplateMethod;

namespace ApplicationWithAllPatterns.CreationalDesignPatterns
{
    class AbstractFactoryPattern
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainAbstractFactory.Make);
        }
    }
}
