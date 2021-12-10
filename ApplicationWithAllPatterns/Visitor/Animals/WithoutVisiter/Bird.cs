using System;

namespace Visitor.Animals.WithoutVisiter
{
    class Bird : Animal
    {
        public override void Voice() => Console.WriteLine("We say: Chik-chiric");

        //new methods
        public override void Eat()
        {
            Console.WriteLine("We say: Cip cip cip");
        }

        //new methods
        public override void Move()
        {
            Console.WriteLine("We wanna fly");
        }

        //new methods
        public override void Stand()
        {
            Console.WriteLine("We can't stand, bacause we are flying");
        }
    }
}
