namespace Visitor.Animals.WithVisiter
{
    abstract class Animal
    {
        public abstract void Accept(IVisiter visiter);
    }
}
