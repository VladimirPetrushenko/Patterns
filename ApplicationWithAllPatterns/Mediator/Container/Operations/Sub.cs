using Mediator.Container.Interfaces;
namespace Mediator.Container.Operations
{
    class Sub : ICalc
    {
        public string Operation => "-";

        public double Result(double x, double y) => x - y;
    }
}
