using State;
using TemplateMethod;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    class StatePattern
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainState.Make);
        }
    }
}
