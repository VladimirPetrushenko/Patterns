using System;

namespace Visitor.Animals.WithVisiter
{
    class VoiceVisiter : IVisiter
    {
        public void Visit(Bird bird)
        {
            Console.WriteLine("We say: Chik-chiric");
        }

        public void Visit(Dog dog)
        {
            Console.WriteLine("We say: Gav");
        }

        public void Visit(Cat cat)
        {
            Console.WriteLine("We say: Myay");
        }
    }
}
