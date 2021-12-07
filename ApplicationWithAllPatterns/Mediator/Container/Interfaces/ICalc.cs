namespace Mediator.Container.Interfaces
{
    interface ICalc
    {
        string Operation { get; }
        double Result(double x, double y);
    }
}
