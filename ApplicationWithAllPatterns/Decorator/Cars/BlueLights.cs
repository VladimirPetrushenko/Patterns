namespace Decorator.Cars
{
    internal class BlueLights : AudiDecorator
    {
        private readonly Audi audi;

        public BlueLights(Audi audi)
        {
            this.audi = audi;
        }

        public override string Complectation()
        {
            return audi.Complectation() + " + синий свет фар";
        }
    }
}
