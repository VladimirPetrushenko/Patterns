using Mediator.Container.Interfaces;

namespace Mediator.Container.Clients
{
    class Client
    {
        public static void ButtonClick()
        {
            IView view = Container.Instance.Extract<IView>();
            ICalc calc = Container.Instance.Extract<ICalc>();

            _ = double.TryParse(view.X, out double x);
            _ = double.TryParse(view.Y, out double y);

            view.Result = $"{x} {calc.Operation} {y} = {calc.Result(x, y)}";
        }
    }
}
