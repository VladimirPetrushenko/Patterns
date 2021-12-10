namespace Visitor.Animals.WithVisiter
{
    interface IVisiter
    {
        void Visit(Bird bird);
        void Visit(Dog dog);
        void Visit(Cat cat);
    }
}
