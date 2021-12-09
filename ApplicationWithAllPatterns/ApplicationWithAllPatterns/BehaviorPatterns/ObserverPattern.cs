using Observer.SocialNerworkWithEvent;
using Observer.SocialNetworks;
using Observer.University;
using TemplateMethod;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    static class ObserverPattern
    {
        public static void Make()
        {
            Univer.Make();
        }

        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(Univer.Make);
            FunctionalTemplateMethod.Make(TicTocWithoutEvents.Make);
            FunctionalTemplateMethod.Make(TicToc.Make);
        }
    }
}
