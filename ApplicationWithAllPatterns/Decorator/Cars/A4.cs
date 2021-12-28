namespace Decorator.Cars
{
    internal class A4 : Audi
    {
        public override string Complectation()
        {
            return base.Complectation() + " model A4";
        }
    }
}
