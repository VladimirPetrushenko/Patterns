using Mediator.Chat;
using Mediator.Container.Clients;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    static class MediatorPattern
    {
        public static void Make()
        {
            ChatRoom.Make();
            Maker.Make();
        }
    }
}
