namespace Decorator.Cars
{
    internal class A6 : Audi
    {
        public override string Complectation()
        {
            return base.Complectation() + " model A6";
        }
    }
}
