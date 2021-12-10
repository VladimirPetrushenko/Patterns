using System;

namespace Visitor.Animals.WithVisiter
{
    // new class
    class MoveVisiter : IVisiter
    {
        public void Visit(Bird bird) => Console.WriteLine("We wanna fly");

        public void Visit(Dog dog) => Console.WriteLine("Yes, we can go with you");

        public void Visit(Cat cat) => Console.WriteLine("We wanna lie");
    }

    // new class
    class EatVisiter : IVisiter
    {
        public void Visit(Bird bird) => Console.WriteLine("We say: Cip cip cip");

        public void Visit(Dog dog) => Console.WriteLine("Am nam nam Am nam nam");

        public void Visit(Cat cat) => Console.WriteLine("Nyam nyam nyam");
    }

    // new class
    class StandVisiter : IVisiter
    {
        public void Visit(Bird bird) => Console.WriteLine("We can't stand, bacause we are flying");

        public void Visit(Dog dog) => Console.WriteLine("We stand");

        public void Visit(Cat cat) => Console.WriteLine("We can't stand, bacause we are lieing");
    }
}
