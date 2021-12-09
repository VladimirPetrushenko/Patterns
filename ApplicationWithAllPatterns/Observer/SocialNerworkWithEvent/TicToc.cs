using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.SocialNerworkWithEvent
{
    public class TicToc
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
