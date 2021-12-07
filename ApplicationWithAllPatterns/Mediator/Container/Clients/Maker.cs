using Mediator.Container.Interfaces;
using Mediator.Container.Operations;
using Mediator.Container.Views;

namespace Mediator.Container.Clients
{
    public class Maker
    {
        public static void Make() { 
            Container container = Container.Instance;

            container.Register<ICalc>(new Sum());
            container.Register<IView>(new ConsoleView());

            Client.ButtonClick();

            container.Unregister<ICalc>();
            container.Register<ICalc>(new Sub());

            Client.ButtonClick();
        }
    }
}
