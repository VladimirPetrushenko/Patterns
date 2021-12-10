namespace Visitor.Animals.WithVisiter
{
    class Bird : Animal
    {
        public override void Accept(IVisiter visiter)
        {
            visiter.Visit(this);
        }
    }
}
