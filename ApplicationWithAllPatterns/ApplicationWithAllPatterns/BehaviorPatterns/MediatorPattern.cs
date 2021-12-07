using Mediator.Chat;
using Mediator.Container.Clients;
using TemplateMethod;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    static class MediatorPattern
    {
        public static void Make()
        {
            ChatRoom.Make();
            Maker.Make();
        }

        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(Maker.Make);
            FunctionalTemplateMethod.Make(ChatRoom.Make);
        }
    }
}
