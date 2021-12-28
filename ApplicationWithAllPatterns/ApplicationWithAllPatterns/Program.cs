using ApplicationWithAllPatterns.BehaviorPatterns;
using ApplicationWithAllPatterns.CreationalDesignPatterns;
using ApplicationWithAllPatterns.StructuralPatterns;

namespace ApplicationWithAllPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //StrategyPattern.Make();
            //TemplateMethodPattern.Make();
            //MediatorPattern.MakeWithTemplateMethod();
            //IteratorPattern.MakeWithTemplateMethod();
            //ObserverPattern.MakeWithTemplateMethod();
            //VisiterPatterns.MakeWithTemplateMethod();
            //StatePattern.MakeWithTemplateMethod();
            //ChainOfResponsibilityPattern.MakeWithTemplateMethod();

            //SingletonPattern.MakeWithTemplateMethod();
            //AbstractFactoryPattern.MakeWithTemplateMethod();
            //FactoryMethodPatterns.MakeWithTemplateMethod();

            FacadePattern.MakeWithTemplateMethod();
        }

    }
}
