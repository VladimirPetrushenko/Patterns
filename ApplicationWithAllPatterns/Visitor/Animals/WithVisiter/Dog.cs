namespace Visitor.Animals.WithVisiter
{
    class Dog : Animal
    {
        public override void Accept(IVisiter visiter)
        {
            visiter.Visit(this);
        }
    }
}
