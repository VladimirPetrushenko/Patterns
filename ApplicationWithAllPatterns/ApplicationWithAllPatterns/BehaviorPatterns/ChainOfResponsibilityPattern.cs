using ChainOfResponsibility;
using TemplateMethod;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    class ChainOfResponsibilityPattern
    {
        public static void MakeWithTemplateMethod()
        {
            var chain = new MainChain();
            FunctionalTemplateMethod.Make(chain.Make);
        }
    }
}
