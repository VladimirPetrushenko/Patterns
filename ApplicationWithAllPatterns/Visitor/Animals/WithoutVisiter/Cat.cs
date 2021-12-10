using System;

namespace Visitor.Animals.WithoutVisiter
{
    class Cat : Animal
    {
        public override void Voice() => Console.WriteLine("We say: Myay");


        //new methods
        public override void Eat()
        {
            Console.WriteLine("Nyam nyam nyam");
        }

        //new methods
        public override void Move()
        {
            Console.WriteLine("We wanna lie");
        }

        //new methods
        public override void Stand()
        {
            Console.WriteLine("We can't stand, bacause we are lieing");
        }
    }
}
