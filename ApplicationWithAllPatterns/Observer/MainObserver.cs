using Observer.SocialNerworkWithEvent;
using Observer.SocialNetworks;
using Observer.University;
using System;

namespace Observer
{
    public class MainObserver
    {
        public static void Make()
        {
            Console.WriteLine("Pattern Observer");

            Console.WriteLine("\nUniversity");
            Univer.Make();

            Console.WriteLine("\nTicTok");
            TicTocWithoutEvents.Make();

            Console.WriteLine("\nTicTok events");
            TicToc.Make();
        }
    }
}
