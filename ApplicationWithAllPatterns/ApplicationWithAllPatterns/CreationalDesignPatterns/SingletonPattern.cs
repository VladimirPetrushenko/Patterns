using Singleton;
using TemplateMethod;

namespace ApplicationWithAllPatterns.CreationalDesignPatterns
{
    class SingletonPattern
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainSingleton.Make);
        }
    }
}
