using System;

namespace Visitor.Animals.WithoutVisiter
{
    class Dog : Animal
    {
        public override void Voice() => Console.WriteLine("We say: Gav");

        //new methods
        public override void Eat()
        {
            Console.WriteLine("Am nam nam Am nam nam");
        }

        //new methods
        public override void Move()
        {
            Console.WriteLine("Yes, we can go with you");
        }

        //new methods
        public override void Stand()
        {
            Console.WriteLine("We stand");
        }
    }
}
