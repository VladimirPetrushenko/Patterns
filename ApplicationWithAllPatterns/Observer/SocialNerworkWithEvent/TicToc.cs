using System;

namespace Observer.SocialNerworkWithEvent
{
    class TicToc
    {
        public static void Make()
        {
            var vladimir = new TicTocUser("Vladimir");
            var evgeniy = new TicTocUser("Evgeniy");
            var margo = new TicTocUser("Margorita");

            vladimir += evgeniy;
            vladimir += margo;

            vladimir.PublishContent("something");

            Console.WriteLine();
            vladimir -= margo;

            vladimir.PublishContent("new video");
        }
    }
}
