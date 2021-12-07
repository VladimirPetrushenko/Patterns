using Mediator.Container.Interfaces;

namespace Mediator.Container.Operations
{
    class Mul : ICalc
    {
        public string Operation => "*";

        public double Result(double x, double y) => x * y;
    }
}
