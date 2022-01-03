using System.Collections.Generic;

namespace Visitor.Animals.WithVisiter
{
    class MainWithVisiter
    {
        public static void Make()
        {
            var animals = new List<Animal>
            {
                new Bird(),
                new Cat(),
                new Dog(),
            };

            var voicer = new VoiceVisiter();

            //Why do i extract method? Because we can do it
            //Without Visiter we need to call differetn method
            //With Visiter we use only Accept
            VisiterCall(animals, voicer);
            System.Console.WriteLine();

            // new
            var mover = new MoveVisiter();
            VisiterCall(animals, mover);
            System.Console.WriteLine();

            // new
            var eater = new EatVisiter();
            VisiterCall(animals, eater);
            System.Console.WriteLine();

            // new
            var stader = new StandVisiter();
            VisiterCall(animals, stader);
        }

        private static void VisiterCall(List<Animal> animals, IVisiter voicer)
        {
            foreach (var animal in animals)
            {
                animal.Accept(voicer);
            }
        }
    }
}
