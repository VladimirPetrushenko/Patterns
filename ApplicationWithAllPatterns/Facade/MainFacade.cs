using Facade.Engines;

namespace Facade
{
    public class MainFacade
    {
        public static void Make()
        {
            Car car = new Car();
            CarFacad facad = new CarFacad(car);

            facad.TurnOn();
            facad.CruizControle();
            facad.TurnOff();
        }
    }
}
