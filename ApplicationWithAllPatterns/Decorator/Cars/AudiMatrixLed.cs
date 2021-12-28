namespace Decorator.Cars
{
    internal class AudiMatrixLed : AudiDecorator
    {
        private readonly Audi audi;

        public AudiMatrixLed(Audi audi)
        {
            this.audi = audi;
        }

        public override string Complectation()
        {
            return audi.Complectation() + " + Особенная форма фар";
        }
    }
}
