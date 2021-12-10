namespace Visitor.Animals.WithVisiter
{
    class Cat : Animal
    {
        public override void Accept(IVisiter visiter)
        {
            visiter.Visit(this);
        }
    }
}
