using ApplicationWithAllPatterns.BehaviorPatterns;
using ApplicationWithAllPatterns.CreationalDesignPatterns;
using ApplicationWithAllPatterns.StructuralPatterns;

namespace ApplicationWithAllPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyPattern.MakeWithTemplateMethod();
            TemplateMethodPattern.MakeWithTemplateMethod();
            MediatorPattern.MakeWithTemplateMethod();
            IteratorPattern.MakeWithTemplateMethod();
            ObserverPattern.MakeWithTemplateMethod();
            VisiterPatterns.MakeWithTemplateMethod();
            StatePattern.MakeWithTemplateMethod();
            ChainOfResponsibilityPattern.MakeWithTemplateMethod();

            SingletonPattern.MakeWithTemplateMethod();
            AbstractFactoryPattern.MakeWithTemplateMethod();
            FactoryMethodPatterns.MakeWithTemplateMethod();
            BuilderPattern.MakeWithTemplateMethod();

            AdapterPattern.MakeWithTemplateMethod();
            FacadePattern.MakeWithTemplateMethod();
            DecoratorPattern.MakeWithTemplateMethod();
            CompositePattern.MakeWithTemplateMethod();
            ProxyPattern.MakeWithTemplateMethod();
        }

    }
}
